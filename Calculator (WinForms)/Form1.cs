using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator_WinForms
{
    public partial class Form1 : Form
    {
        Button[] hexInput, decInput, octInput, binInput;

        Calc calc;

        private string resultText;
        private string fullResultText;

        Color selectedColor = Color.FromKnownColor(KnownColor.Highlight);
        Color nonSelectedColor = Color.FromKnownColor(KnownColor.ControlText);

        //Основание системы счисления
        public int numBase = 10;

        int numberMaxLenght = (int)Math.Log10(long.MaxValue);

        public Form1()
        {
            InitializeComponent();

            calc = new Calc(this);

            resultText = resultTextBox.Text;
            fullResultText = fullResultTextBox.Text;

            #region buttonsArray
            binInput = new Button[] { oneButton, zeroButton };

            octInput = new Button[] { twoButton, threeButton, fourButton, fiveButton,
            sixButton, sevenButton };
            octInput = Concat(binInput, octInput);

            decInput = new Button[] { eightButton, nineButton };
            decInput = Concat(octInput, decInput);

            hexInput = new Button[] { aButton, bButton, cButton, dButton, eButton, fButton };
            hexInput = Concat(decInput, hexInput);
            #endregion

        }
        T[] Concat<T>(T[] a1, T[] a2)
        {
            var result = new T[a1.Length + a2.Length];

            a1.CopyTo(result, 0);
            a2.CopyTo(result, a1.Length);

            return result;
        }
        public string ResultText
        {
            get
            {
                return resultText;
            }
            set
            {
                resultText = value;

                updateResultTextBox();

                if (resultText.Length > 1 || resultText[0] != '-')
                {
                    long number = long.Parse(resultText);
                    hexLabel.Text = Convert.ToString(number, 16);
                    decLabel.Text = value;
                    octLabel.Text = Convert.ToString(number, 8);
                    binLabel.Text = Convert.ToString(number, 2);
                }
            }
        }

        public string FullResultText
        {
            get
            {
                return fullResultText;
            }
            set
            {
                fullResultText = value;

                updateFullResultTextBox();
            }
        }

        void updateResultTextBox()
        {
            string text = resultText;

            if (numBase != 10 && (resultText.Length > 1 || resultText[0] != '-'))
            {
                long number = long.Parse(text);
                text = Convert.ToString(number, numBase).ToUpper();
            }

            resultTextBox.Visible = text.Length <= resultTextBox.MaxLength;
            resultTextBox.Text = text;
        }
        void updateFullResultTextBox()
        {
            string text = fullResultText;

            if (numBase != 10)
            {
                string pattern = @"(^|(\)-){1}|[^\d]{1})(-?\d+)";
                Regex regex = new Regex(pattern);

                text = regex.Replace(text, (match) =>
                {
                    long value = long.Parse(match.Groups[3].Value);

                    return match.Groups[1] + Convert.ToString(value, numBase).ToUpper();
                });
            }

            fullResultTextBox.Visible = text.Length <= fullResultTextBox.MaxLength;
            fullResultTextBox.Text = text;
        }

        private void selectNumeralSystemButton_Click(object sender, EventArgs e)
        {
            switch (numBase)
            {
                case 16:
                    hexButton.ForeColor = nonSelectedColor;
                    hexLabel.ForeColor = nonSelectedColor;
                    break;

                case 10:
                    decButton.ForeColor = nonSelectedColor;
                    decLabel.ForeColor = nonSelectedColor;
                    break;

                case 8:
                    octButton.ForeColor = nonSelectedColor;
                    octLabel.ForeColor = nonSelectedColor;
                    break;

                case 2:
                    binButton.ForeColor = nonSelectedColor;
                    binLabel.ForeColor = nonSelectedColor;
                    break;

                default:
                    break;
            }

            string numSystemName = ((Button)sender).Text;

            switch (numSystemName)
            {
                case "HEX":
                    numBase = 16;

                    hexButton.ForeColor = selectedColor;
                    hexLabel.ForeColor = selectedColor;
                    break;

                case "DEC":
                    numBase = 10;

                    decButton.ForeColor = selectedColor;
                    decLabel.ForeColor = selectedColor;
                    break;

                case "OCT":
                    numBase = 8;

                    octButton.ForeColor = selectedColor;
                    octLabel.ForeColor = selectedColor;
                    break;

                case "BIN":
                    numBase = 2;

                    binButton.ForeColor = selectedColor;
                    binLabel.ForeColor = selectedColor;
                    break;

                default:
                    break;
            }

            numberMaxLenght = (int)Math.Log(long.MaxValue, numBase);

            updateFullResultTextBox();
            updateResultTextBox();

            updateButtons();
        }

        void setButtonsActive(Button[] buttons, bool value)
        {
            foreach (var button in buttons)
            {
                button.Enabled = value;
                
                if(value)
                    button.Font = new Font(button.Font, FontStyle.Bold);
                else
                    button.Font = new Font(button.Font, FontStyle.Regular);
            }
        }
        void updateButtons()
        {
            switch (numBase)
            {
                case 16:
                    setButtonsActive(hexInput, true);
                    break;

                case 10:
                    setButtonsActive(hexInput, false);
                    setButtonsActive(decInput, true);
                    break;

                case 8:
                    setButtonsActive(hexInput, false);
                    setButtonsActive(octInput, true);
                    break;

                case 2:
                    setButtonsActive(hexInput, false);
                    setButtonsActive(binInput, true);
                    break;

                default:
                    break;
            }
        }

        private void digitButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text.Length < numberMaxLenght)
            {
                string value = ((Button)sender).Text.ToLower();

                if (numBase != 0)
                {
                    if (resultTextBox.Text == "0")
                        resultTextBox.Text = value;
                    else
                        resultTextBox.Text += value;

                    long number = Convert.ToInt64(resultTextBox.Text, numBase);
                    ResultText = number.ToString();
                }
                else
                {
                    if (ResultText == "0")
                        ResultText = value;
                    else
                        ResultText += value;
                }
            }
        }

        private void operationButton_Click(object sender, EventArgs e)
        {
            string operation = ((Button)sender).Text.ToLower();
            calc.AddOperation(operation);
        }

        private void notButton_Click(object sender, EventArgs e)
        {
            calc.Not();
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {
            calc.ClearEntry();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            calc.Clear();
        }

        private void clearLastElemButton_Click(object sender, EventArgs e)
        {
            calc.ClearLastElement();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            calc.Equal();
        }

        private void plus_minusButton_Click(object sender, EventArgs e)
        {
            calc.PlusMinus();
        }

        private void roundButton_Click(object sender, EventArgs e)
        {
            calc.Round();
        }

        private void openBracketButton_Click(object sender, EventArgs e)
        {
            calc.OpenBracket();
        }

        private void closeBracketButton_Click(object sender, EventArgs e)
        {
            calc.CloseBracket();
        }
    }
}
