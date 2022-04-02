using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string a, b; //первое и второе числа
        string c;//кодовое название операции

        //Для каждой операции вывести соответствующий символ c пробелами и ждать второе число
        //При смене операции менять символ 


        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;//Запрещаем ввод с клавиатуры пользователю для избежания большенства ошибок формата ввода
            button14.Enabled = false;
            button17.Enabled = true;
            button22.Enabled = false;
            button21.Enabled = true;
            button20.Enabled = true;
            button18.Text = "C";
            button18.BackColor = System.Drawing.Color.Orange;
            button14.BackColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            button21.Enabled = false;
            button22.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)//Кнопка АС
        {
            a = "";
            b = "";
            c = "";
            button17.Enabled = true;
            button22.Enabled = false;
            button21.Enabled = true;
            button20.Enabled = true;
            button18.Text = "C";
            textBox1.Text = "";
            button18.BackColor = System.Drawing.Color.Orange;

        }

        private void button15_Click(object sender, EventArgs e)//+
        {
            c="+";
            textBox1.Text = textBox1.Text.Trim(new char[] { ' ', '+', '—', 'X', '/', '^' });
            a = textBox1.Text;
            textBox1.Text += " + ";
            button14.Enabled = true;
            button21.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)//—
        {
            c = "—";
            textBox1.Text = textBox1.Text.Trim(new char[] { ' ', '+', '—', 'X', '/', '^' });
            a = textBox1.Text;
            textBox1.Text += " — ";
            button14.Enabled = true;
            button21.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)// :
        {
            c = "/";
            textBox1.Text = textBox1.Text.Trim(new char[] { ' ', '+', '—', 'X', '/', '^' });
            a = textBox1.Text;
            textBox1.Text += " / ";
            button14.Enabled = true;
            button21.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)// ^
        {
            c = "^";
            textBox1.Text = textBox1.Text.Trim(new char[] { ' ', '+', '—', 'X', '/', '^' });
            a = textBox1.Text;
            textBox1.Text += " ^ ";
            button14.Enabled = true;
            button21.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)//sqrt
        {
            a = textBox1.Text;
            textBox1.Text = "sqrt("+a+") = ";
            textBox1.Text += Math.Sqrt(Double.Parse(a));//Сразу считаем квадратный корень
            textBox1.Text += Environment.NewLine;
            button17.Enabled = false;
            button14.Enabled = false;
            button22.Enabled = false;
            button20.Enabled = false;
            button18.BackColor = System.Drawing.Color.Green;
            button18.Text = "AC";
        }

        private void button14_Click(object sender, EventArgs e)//=
        {

            b = textBox1.Text.Substring(a.Length+3);
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "= ";
            switch (c)
            {
                case "+":
                    textBox1.Text += (Double.Parse(a))+(Double.Parse(b));
                    break;
                case "—":
                    textBox1.Text += (Double.Parse(a))-(Double.Parse(b));
                    break;
                case "X":
                    textBox1.Text += (Double.Parse(a))*(Double.Parse(b));
                    break;
                case "/":
                    if (Int32.Parse(b) != 0)
                        textBox1.Text += (Double.Parse(a)) / (Double.Parse(b));
                    else
                        textBox1.Text = "Деление на ноль";
                    break;
                case "^":
                    textBox1.Text += Math.Pow((Double.Parse(a)),(Double.Parse(b)));
                    break;
            }

            textBox1.Text += Environment.NewLine;//запретить дальнейший ввод пользователя
            //ждем кнопки АС
            button18.BackColor = System.Drawing.Color.Green;
            button17.Enabled = false;
            button14.Enabled = false;
            button20.Enabled = false;
            button22.Enabled = false;
            button18.Text = "AC";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//*(X)
        {
            c = "X";
            textBox1.Text = textBox1.Text.Trim(new char[] { ' ', '+', '—', 'X', '/', '^' });
            a = textBox1.Text;
            textBox1.Text += " X ";
            button14.Enabled = true;
            button21.Enabled = true;
        }

        private void button22_Click(object sender, EventArgs e)//1/x
        {
            a = textBox1.Text;
            textBox1.Text = "1/" + a + " = ";
            if (Int32.Parse(a) != 0)
                textBox1.Text += 1 / (Double.Parse(a));
            else
                textBox1.Text = "Деление на ноль";
            textBox1.Text += Environment.NewLine;
            button17.Enabled = false;
            button14.Enabled = false;
            button22.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = true;
            button18.BackColor = System.Drawing.Color.Green;
            button18.Text = "AC";
        }

        private void button20_Click(object sender, EventArgs e)//<
        {
            if(textBox1.Text.Length!=0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button21_Click(object sender, EventArgs e)// ---
        {
            textBox1.Text += "-";
            if ( textBox1.Text.StartsWith("--"))
                textBox1.Text=textBox1.Text.Substring(2);
        }
    }
}
