using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cavalry87_Color_Changer
{
    public partial class Main : Form
    {
        // Словари локализации
        private Dictionary<string, string> enLang = new Dictionary<string, string>
        {
            { "BtnApply_Text", "Apply" },
            { "BtnOpenFile_Text", "Choose" },
            { "LabelFileName_Text", "File: " },
            { "LabelRed_Text", "Red" },
            { "LabelGreen_Text", "Green" },
            { "LabelBlue_Text", "Blue" },
            { "LightLabel_Text", "Light" },
            { "LinkLabelLanguage_Text", "Rus" },
            { "LabelCurColor_Text", "  Current color" },
            { "LabelHowTo_Text", "RGB color values are set from 0 to 255 inclusive\r\n\r\nWhen the brightness is 0, the backlight is completely off\r\n" },
    
            // Ошибки и сообщения
            { "Error_Title", "Error" },
            { "Warning_Title", "Warning" },
            { "Success_Title", "Success" },

            { "Error_InvalidFile", "Invalid file type." },
            { "Error_LoadFailed", "An error occurred while loading data: {0}" },
            { "Error_FileNotSelected", "Please select a profile file first" },
            { "Error_UpdateFailed", "An error occurred: {0}" },
            { "Success_Update", "Values successfully updated!" }
        };

        private Dictionary<string, string> ruLang = new Dictionary<string, string>
        {
            { "BtnApply_Text", "Применить" },
            { "BtnOpenFile_Text", "Выбрать" },
            { "LabelFileName_Text", "Файл: " },
            { "LabelRed_Text", "Красный" },
            { "LabelGreen_Text", "Зеленый" },
            { "LabelBlue_Text", "Синий" },
            { "LightLabel_Text", "Яркость" },
            { "LinkLabelLanguage_Text", "Eng" },
            { "LabelCurColor_Text", "Текущий цвет" },
            { "LabelHowTo_Text", "Значения RGB цветов устанавливаются в диапазоне от 0 до 255\r\n\r\nПри яркости равной 0 подсветка выключена\r\n" },
    
            // Ошибки и сообщения
            { "Error_Title", "Ошибка" },
            { "Warning_Title", "Предупреждение" },
            { "Success_Title", "Успех" },

            { "Error_InvalidFile", "Неверный тип файла." },
            { "Error_LoadFailed", "Произошла ошибка при загрузке данных: {0}" },
            { "Error_FileNotSelected", "Сначала выберите файл профиля" },
            { "Error_UpdateFailed", "Произошла ошибка: {0}" },
            { "Success_Update", "Значения успешно обновлены!" }
        };


        private bool language = false;

        private ColorDialog colorDialog;
        private string FilePath;            // Путь к JSON-файлу
        private string[] lines;             // Хранение содержимого файла
        private bool isValidFile = false;   // Флаг, указывающий, что файл корректен

        private byte redValue;
        private byte greenValue;
        private byte blueValue;
        private decimal lightValue;

        public Main()
        {
            InitializeComponent();

            // Устанавливаем язык по умолчанию
            SetLanguage(ruLang);

            // Инициализация компонентов
            colorDialog = new ColorDialog();

            var textBoxes = new[] { textBoxRed, textBoxGreen, textBoxBlue }; // Список текстовых полей

            // Обрабатываем события всех текстовых полей
            foreach (var textBox in textBoxes)
            {
                textBox.TextChanged += TextBox_TextChanged; // Обработчик для TextChanged
                textBox.KeyPress += TextBox_KeyPress;      // Обработчик для KeyPress
            }

        }

        private void LoadValuesFromFile()
        {
            try
            {
                // Считываем содержимое файла
                lines = File.ReadAllLines(FilePath);

                // Проверяем наличие строки "AppLink" - простая проверка на то, что это файл профиля и он нам подходит
                isValidFile = lines.Any(line => line.Contains("\"AppLink\"")); // Проверяем, подходит ли файл

                if (!isValidFile)
                {
                    FilePath = null; // Сбрасываем путь к файлу
                    MessageBox.Show(language ? enLang["Error_InvalidFile"] : ruLang["Error_InvalidFile"],
                            language ? enLang["Error_Title"] : ruLang["Error_Title"],
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Обновляем значения в промежуточных переменных
                foreach (string line in lines)
                {
                    if (line.Contains("\"Red\""))
                    {
                        redValue = byte.Parse(GetValue(line));
                    }
                    else if (line.Contains("\"Green\""))
                    {
                        greenValue = byte.Parse(GetValue(line));
                    }
                    else if (line.Contains("\"Blue\""))
                    {
                        blueValue = byte.Parse(GetValue(line));
                    }
                    else if (line.Contains("\"Light\""))
                    {
                        lightValue = decimal.Parse(GetValue(line));
                    }
                }

                // Назначаем значения в текстовые поля и другие элементы управления
                textBoxRed.Text = redValue.ToString();
                textBoxGreen.Text = greenValue.ToString();
                textBoxBlue.Text = blueValue.ToString();
                numericLight.Value = lightValue;
                // Устанавливаем цвет панели
                panel1.BackColor = Color.FromArgb(redValue, greenValue, blueValue);
                // Указываем имя файла
                labelFileName.Text = (language ? enLang["LabelFileName_Text"] : ruLang["LabelFileName_Text"]) + Path.GetFileName(FilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(language ? enLang["Error_LoadFailed"] : ruLang["Error_LoadFailed"], ex.Message),
                        language ? enLang["Error_Title"] : ruLang["Error_Title"],
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private string GetValue(string line)
        {
            int startIndex = line.IndexOf(":") + 1;
            int endIndex = line.IndexOf(",");
            if (endIndex == -1) endIndex = line.Length;
            return line.Substring(startIndex, endIndex - startIndex).Trim();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox textBox && int.TryParse(textBox.Text, out int value))
            {
                // Если значение больше 255, устанавливаем 255
                if (value > 255)
                {
                    textBox.Text = "255";
                    textBox.SelectionStart = textBox.Text.Length; // Перемещаем курсор в конец поля
                }
                else if (value < 0) // Если значение меньше 0, устанавливаем 0
                {
                    textBox.Text = "0";
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }

            // Проверяем, что все текстовые поля содержат корректные значения
            if (byte.TryParse(textBoxRed.Text, out byte red) &&
                byte.TryParse(textBoxGreen.Text, out byte green) &&
                byte.TryParse(textBoxBlue.Text, out byte blue))
            {
                // Устанавливаем цвет панели
                panel1.BackColor = Color.FromArgb(red, green, blue);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры, клавишу Backspace и Delete
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Если нажата не цифра и не управляющая клавиша
            {
                e.Handled = true;   // Означает, что событие обработано,
                                    // и нажатая клавиша не будет добавлена в текстовое поле.
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                // Полученный цвет
                Color chosenColor = colorDialog.Color;
                // Устанавливаем цветом панели
                panel1.BackColor = chosenColor;
                // Передаем значения RGB в соответствующие поля
                textBoxRed.Text = chosenColor.R.ToString();
                textBoxGreen.Text = chosenColor.G.ToString();
                textBoxBlue.Text = chosenColor.B.ToString();
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                //Проверяем задан ли путь к файлу и есть ли он вобще
                if (String.IsNullOrEmpty(FilePath) || !File.Exists(FilePath))
                {
                    MessageBox.Show(language ? enLang["Error_FileNotSelected"] : ruLang["Error_FileNotSelected"],
                            language ? enLang["Warning_Title"] : ruLang["Warning_Title"],
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Прерываем выполнение метода
                }

                // Обновляем значения в строках
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("\"Red\""))
                    {
                        lines[i] = UpdateValue(lines[i], textBoxRed.Text);
                    }
                    else if (lines[i].Contains("\"Green\""))
                    {
                        lines[i] = UpdateValue(lines[i], textBoxGreen.Text);
                    }
                    else if (lines[i].Contains("\"Blue\""))
                    {
                        lines[i] = UpdateValue(lines[i], textBoxBlue.Text);
                    }
                    else if (lines[i].Contains("\"Light\""))
                    {
                        lines[i] = UpdateValue(lines[i], numericLight.Value.ToString());
                    }
                }

                // Записываем обновленные строки обратно в файл
                File.WriteAllLines(FilePath, lines);
                // Если операция прошла успешно, пишем что всё ОК
                MessageBox.Show(language ? enLang["Success_Update"] : ruLang["Success_Update"],
                        language ? enLang["Success_Title"] : ruLang["Success_Title"],
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(language ? enLang["Error_UpdateFailed"] : ruLang["Error_UpdateFailed"], ex.Message),
                        language ? enLang["Error_Title"] : ruLang["Error_Title"],
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string UpdateValue(string line, string newValue)
        {
            // Находим место, где нужно заменить значение
            int startIndex = line.IndexOf(":") + 1;
            int endIndex = line.IndexOf(",");
            if (endIndex == -1) endIndex = line.Length;

            // Возвращаем строку с обновленным значением
            return line.Substring(0, startIndex) + " " + newValue + line.Substring(endIndex);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь к выбранному файлу
                FilePath = openFileDialog1.FileName;
                LoadValuesFromFile();                
            }
        }

        private void SetLanguage(Dictionary<string, string> localization)
        {
            BtnApply.Text = localization["BtnApply_Text"];
            BtnOpenFile.Text = localization["BtnOpenFile_Text"];
            labelFileName.Text = localization["LabelFileName_Text"] + (string.IsNullOrEmpty(FilePath) ? "" : Path.GetFileName(FilePath));
            LightLabel.Text = localization["LightLabel_Text"];
            LinkLabelLanguage.Text = localization["LinkLabelLanguage_Text"];
            LabelCurColor.Text = localization["LabelCurColor_Text"];
            LabelHowTo.Text = localization["LabelHowTo_Text"];
        }

        private void linkLabelLanguage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            language = !language; // Переключаем флаг языка
            SetLanguage(language ? enLang : ruLang);
        }
    }
}
