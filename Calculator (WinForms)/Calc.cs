using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator_WinForms
{
    class Calc
    {
        delegate long OperationDelegate(long x, long y);

        //Порядок важен
        readonly OperationDelegate[] operationDelegates = {
            Mathematics.Lsh,
            Mathematics.Rsh,
            Mathematics.Mult,
            Mathematics.Div,
            Mathematics.Mod,
            Mathematics.And,
            Mathematics.Minus,
            Mathematics.Plus,
            Mathematics.Or,
            Mathematics.Xor,
        };
        readonly string[] operations = { "lsh", "rsh", "×", "÷", "mod", "and",
         "-", "+", "or", "xor", };
        readonly string digits = "0123456789";
        readonly string brackets = "()";

        Form1 form;

        public Calc(Form1 value)
        {
            form = value;
        }

        public void RemoveLastOperation()
        {
            string text = form.FullResultText;

            while (text.Length > 0 && !(digits + brackets).Contains(text.Last()))
            {
                text = text.Remove(text.Length - 1);
            }

            form.FullResultText = text;
        }

        public void AddOperation(string value)
        {
            if (form.FullResultText.Length > 0 && form.ResultText == "0")
            {
                RemoveLastOperation();
            }
            else
            {
                form.FullResultText += form.ResultText;
                form.ResultText = "0";
            }

            form.FullResultText += value;
        }

        public void OpenBracket()
        {
            if (form.FullResultText.Length == 0 || form.FullResultText.Last() != '(')
                    form.FullResultText += '(';
            
        }

        public void CloseBracket()
        {
            string text = form.FullResultText;

            if (text.Length > 1)
            {
                int openBracketsCount = text.Count(a =>
                {
                    return a == '(';
                });
                int closeBracketsCount = text.Count(a =>
                {
                    return a == ')';
                });

                if (openBracketsCount > closeBracketsCount)
                {
                    form.FullResultText += form.ResultText + ")+";
                    form.ResultText = "0";
                }
            }
        }

        public void Not()
        {
            long number = long.Parse(form.ResultText);
            number = ~number;
            form.ResultText = number.ToString();
        }

        public void Round()
        {
            string text = form.ResultText;

            if (text != "0")
            {
                long number = long.Parse(text);
                long num = number;

                for (int i = 0; i < text.Length; i++)
                {
                    long digit = Mathematics.Mod(num, 10);

                    if (digit != 0)
                    {
                        if (digit < 5)
                        {
                            number -= digit * (long)Math.Pow(10, i);
                        }
                        else
                        {
                            number -= digit * (long)Math.Pow(10, i);
                            number += (long)Math.Pow(10, i + 1);
                        }
                        break;
                    }
                    number /= 10;
                }

                form.ResultText = number.ToString();
            }
        }

        public void PlusMinus()
        {
            string text = form.ResultText;

            if (text != "0")
            {
                if (text[0] == '-')
                    text = text.Substring(1);
                else
                    text = "-" + text;

                form.ResultText = text;
            }
        }

        public void ClearEntry()
        {
            form.ResultText = "0";
        }
        public void Clear()
        {
            form.ResultText = "0";
            form.FullResultText = "";
        }
        public void ClearLastElement()
        {
            if (form.numBase == 10 || form.ResultText == "0")
            {
                if (form.ResultText.Length > 1)
                {
                    form.ResultText = form.ResultText.Remove(form.ResultText.Length - 1);
                }

                else if (form.ResultText != "0")
                    form.ResultText = "0";

                else if (form.FullResultText.Length > 0)
                {
                    RemoveLastOperation();

                    string text = form.FullResultText;

                    int i = text.Length - 1;

                    if (!brackets.Contains(text.Last()))
                    {
                        while ((digits + '-').Contains(text[i]))
                        {
                            i--;
                        }
                        i++;

                        form.ResultText = text.Substring(i);
                    }

                    form.FullResultText = text.Remove(i);
                }
            }
            else
            {
                long val = long.Parse(form.ResultText);

                if (val >= form.numBase)
                {
                    val /= form.numBase;
                    form.ResultText = val.ToString();
                }
                else
                    form.ResultText = "0";
            }

        }


        public void Equal()
        {
            if (form.FullResultText.Length != 0)
            {
                string text = form.FullResultText + form.ResultText;

                text = fixBrackets(text);

                form.ResultText = compute(text);
                form.FullResultText = "";
            }
        }
        //закрывает все незакрытые скобки
        string fixBrackets(string text)
        {
            int openBracketsCount = text.Count(a =>
            {
                return a == '(';
            });
            int closeBracketsCount = text.Count(a =>
            {
                return a == ')';
            });
            for (int i = 0; i < openBracketsCount - closeBracketsCount; i++)
            {
                text += ')';
            }
            return text;
        }
        string compute(string value)
        {
            //если есть скобки, то вычисляем сначала их
            if (value.Contains('('))
            {
                string pattern = @"\(([^\(]+?)\)";

                while (true)
                {
                    Match match = Regex.Match(value, pattern);

                    if (match.Success)
                    {
                        string val = match.Groups[1].Value;
                        string result = compute(val);

                        value = value.Replace(match.Groups[0].Value, result);
                    }
                    else
                        break;
                }
            }

            string preOpPattern = @"(^|[^\d]{1})(-?[\d]+)";
            string postOpPattern = @"(-?[\d]+)";

            for (int i = 0; i < operationDelegates.Length; i++)
            {
                string operation = operations[i];
                string pattern = preOpPattern;

                if (operation == "+")
                    pattern += "\\";

                pattern += operation + postOpPattern;

                while (true)
                {//тут разбираем математические выражения
                    Match match = Regex.Match(value, pattern);

                    if (match.Success)
                    {
                        long val1 = long.Parse(match.Groups[2].Value);
                        long val2 = long.Parse(match.Groups[3].Value);

                        long result = operationDelegates[i](val1, val2);
                        string resultString = result.ToString();
                        string replacementString = match.Groups[2].Value + operation
                            + match.Groups[3].Value;

                        value = value.Replace(replacementString, resultString);
                    }
                    else
                        break;
                }
            }

            return value;
        }

    }
}
