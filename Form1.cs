using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace komand
{
    public partial class Form1 : Form
    {
        private readonly Stack<string> bufferStack = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
            GenerateOperatorButtons();
        }

        private void GenerateOperatorButtons()
        {
            string[] operators = { "+", "-", "*", "/", "(", ")" };

            foreach (string op in operators)
            {
                Button btn = new Button();
                btn.Text = op;
                btn.Click += btnOperator_Click;
                btn.Width = 50;
                btn.Height = 50;
                flpOperators.Controls.Add(btn);
            }
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBoxIn.Text += btn.Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBoxIn.Text += btn.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxIn.Clear();
        }

        private void btnSaveBuf_Click(object sender, EventArgs e)
        {
            bufferStack.Push(textBoxIn.Text);
            textBoxIn.Clear();
        }

        private void btnRestoreBuf_Click(object sender, EventArgs e)
        {
            if (bufferStack.Count > 0)
            {
                textBoxIn.Text = bufferStack.Pop();
            }
        }

        private void btnClearBuf_Click(object sender, EventArgs e)
        {
            bufferStack.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                var analyzer = new Analyzer(textBoxIn.Text);
                analyzer.Calculate();
                textBoxOut.Text = analyzer.Result.ToString();
            }
            catch (Exception ex)
            {
                textBoxOut.Text = ex.Message;
            }
        }
    }

    public class Analyzer
    {
        private readonly string inputString;
        private readonly List<CalcObject> calcObjects = new List<CalcObject>();
        private readonly Stack<CalcObject> stack = new Stack<CalcObject>();

        public double Result { get; private set; }

        public Analyzer(string inputString)
        {
            this.inputString = inputString;
        }

        public void Calculate()
        {
            InputStringToCalcObjects();
            ExpressionToRPN();
            EvaluateRPN();
        }

        private void InputStringToCalcObjects()
        {
            string[] operators = { "+", "-", "*", "/", "(", ")" };

            string currentNumber = "";

            for (int i = 0; i < inputString.Length; i++)
            {
                if (Char.IsDigit(inputString[i]) || inputString[i] == '.')
                {
                    currentNumber += inputString[i];
                }
                else if (operators.Contains(inputString[i].ToString()))
                {
                    if (!string.IsNullOrEmpty(currentNumber))
                    {
                        calcObjects.Add(new CalcObject(currentNumber, 0));
                        currentNumber = "";
                    }

                    int priority = GetOperatorPriority(inputString[i]);
                    calcObjects.Add(new CalcObject(inputString[i].ToString(), priority));
                }
            }

            if (!string.IsNullOrEmpty(currentNumber))
            {
                calcObjects.Add(new CalcObject(currentNumber, 0));
            }
        }

        private int GetOperatorPriority(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '(':
                case ')':
                    return 0;
                default:
                    throw new ArgumentException("Невідомий оператор: " + op);
            }
        }

        private void ExpressionToRPN()
        {
            foreach (var obj in calcObjects)
            {
                if (obj.Priority == 0) // Дужка
                {
                    if (obj.Token == "(")
                    {
                        stack.Push(obj);
                    }
                    else if (obj.Token == ")")
                    {
                        while (stack.Count > 0 && stack.Peek().Token != "(")
                        {
                            stack.Push(obj);
                        }

                        if (stack.Count > 0 && stack.Peek().Token == "(")
                        {
                            stack.Pop(); // Видаляємо відкриваючу дужку зі стеку
                        }
                        else
                        {
                            throw new ArgumentException("Неправильне використання дужок");
                        }
                    }
                }
                else // Оператор
                {
                    while (stack.Count > 0 && stack.Peek().Priority >= obj.Priority)
                    {
                        stack.Push(obj);
                    }
                }
            }

            while (stack.Count > 0)
            {
                stack.Push(stack.Pop()); // Все, що залишиться у стеці, є результатом в оберненій польській нотації
            }
        }

        private void EvaluateRPN()
        {
            Stack<double> evalStack = new Stack<double>();

            foreach (var obj in stack)
            {
                if (obj.Priority == 0) // Дужка
                {
                    throw new ArgumentException("Неправильне використання дужок");
                }
                else // Оператор
                {
                    if (evalStack.Count < 2)
                    {
                        throw new ArgumentException("Недостатньо операндів для операції");
                    }

                    double op2 = evalStack.Pop();
                    double op1 = evalStack.Pop();

                    double result = PerformOperation(op1, op2, obj.Token);

                    evalStack.Push(result);
                }
            }

            if (evalStack.Count != 1)
            {
                throw new ArgumentException("Неправильний формат виразу");
            }

            Result = evalStack.Pop();
        }

        private double PerformOperation(double op1, double op2, string op)
        {
            switch (op)
            {
                case "+":
                    return op1 + op2;
                case "-":
                    return op1 - op2;
                case "*":
                    return op1 * op2;
                case "/":
                    if (op2 == 0)
                    {
                        throw new DivideByZeroException("Ділення на нуль");
                    }
                    return op1 / op2;
                default:
                    throw new ArgumentException("Невідомий оператор: " + op);
            }
        }
    }

    public class CalcObject
    {
        public CalcObject(string token, int priority)
        {
            Token = token;
            Priority = priority;
        }

        public string Token { get; set; }
        public int Priority { get; set; }
    }
}
