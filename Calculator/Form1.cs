using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Achieve;
using System.Speech.Synthesis;
namespace Calculator
{
    public partial class Form1 : Form
    {
        int flag = 0;
        
        string lastnum ="";
        
        SpeechSynthesizer ss = new SpeechSynthesizer();
       
        
        
        public Form1()
        {
            InitializeComponent();
     
            ss.Rate = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (flag==0)
            {
                label1.Text = "1";
               
                flag = 1;
            }
           else
            {
                label1.Text += "1";
                

            }
          
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (flag==0 )
            {
                label1.Text = "2";
                flag = 1;
            }
            else
            {
                label1.Text += "2";
            }
           
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {

           
            if (flag == 0)
            {
                label1.Text = "3";
                flag = 1;
            }
            else
            {
                label1.Text += "3";
            }
          
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (flag == 0)
            {
                label1.Text = "4";
                flag = 1;
            }
            else
            {
                label1.Text += "4";
            }
         
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (flag == 0)
            {
                label1.Text = "5";
                flag = 1;
            }
          
            else
            {
                label1.Text += "5";
            } 
          
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            if (flag == 0)
            {
                label1.Text = "6";
                flag = 1;
            }
            else
            {
                label1.Text += "6";
            }
           
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
            if (flag == 0)
            {
                label1.Text = "7";
                flag = 1;
            }
            
            else
            {
                label1.Text += "7";
            }
          
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (flag == 0)
            {
                label1.Text = "8";
                flag = 1;
            }
            else
            {
                label1.Text += "8";
            }
           
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            if (flag == 0)
            {
                label1.Text = "9";
                flag = 1;
            }
            else
            {
                label1.Text += "9";
            }
           
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("9");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                label1.Text = "0";
                flag = 1;
            }
            else
            {
                label1.Text += "0";
            }
          
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("0");
        }

        private void button17_Click(object sender, EventArgs e)//删除回退（一次仅删除一位）
        {
            string subString = label1.Text;
            
                subString = subString.Substring(0, subString.Length - 1);
                label1.Text = subString;          

        }

        private void button18_Click(object sender, EventArgs e) //清除显示区
        {
            label1.Text = "0";
            label2.Text = "";
            flag = 0;
        }

        private void button16_Click(object sender, EventArgs e) //点击加号
        {
            string lastmatch = "";

            Regex reg = new Regex(@"[\+|×|\-|÷|%]");
            MatchCollection matchs = reg.Matches(label2.Text);
            int matchcount = matchs.Count;
            if (matchcount > 0)
            {
                lastmatch = matchs[matchcount - 1].Value;//确定上一个运算符是什么
            }
                       

            if (label1.Text.Length>0) 
            {

                string nowstring = label1.Text;
                label2.Text += nowstring+"+";

            }
            flag = 0;//修改标志值

           
            if (lastmatch== "+") //当上一个运算符为加号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Add(b, a);
                label1.Text = result.ToString();


            }
            if (lastmatch == "×") //当上一个运算符为乘号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Multi(b, a);
                label1.Text = result.ToString();
            }
            if (lastmatch == "-") //当上一个运算符为减号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Sub(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "÷") //当上一个运算符为除号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Divi(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "%") //当上一个运算符为求余号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Surplus(b, a);
                label1.Text = result.ToString();

            }
            ss.Speak("加");
            lastnum = label1.Text;


        }

        private void button10_Click(object sender, EventArgs e) //等号
        {
            int label2_lenth = label2.Text.Length;

           
            if ( label2.Text.Substring(label2_lenth-1,1) == "+") //调用dll实现加法
            {
                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Add(b, a);
                label1.Text = result.ToString();
                label2.Text = "";
            }
            else if (label2.Text.Substring(label2_lenth - 1, 1) == "-") //调用dll实现减法
            {
                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Sub(b, a);
                label1.Text = result.ToString();
                label2.Text = "";
            }
           else if (label2.Text.Substring(label2_lenth - 1, 1) == "×") //调用dll实现乘法
            {
                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Multi(b, a);
                label1.Text = result.ToString();
                label2.Text = "";
            }
           else if (label2.Text.Substring(label2_lenth - 1, 1) == "÷") //调用dll实现除法
            {
                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Divi(b, a);
                label1.Text = result.ToString();
                label2.Text = "";
            }
            else if (label2.Text.Substring(label2_lenth - 1, 1) == "%") //调用dll实现求余
            {
                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Surplus(b, a);
                label1.Text = result.ToString();
                label2.Text = "";
            }
            flag = 0;
            string myresult = label1.Text;
            ss.Speak("等于");
            ss.Speak(myresult);
        }

        private void button13_Click(object sender, EventArgs e) //小数点
        {
            if (flag == 0)
            {
                label1.Text = "0";
                flag = 1;
            }
            else
            {
                label1.Text += ".";
            }
            Regex reg = new Regex(@"\.");
            MatchCollection matches = reg.Matches(label1.Text);
            int pointcount = matches.Count; //输入的小数点个数
            if (pointcount > 1)
            {
                string subString = label1.Text;
                subString = subString.Substring(0, subString.Length - 1);
                label1.Text = subString;
                MessageBox.Show("非法输入，请重新输入！");
            }
            if (label1.Text.Length > 18)
            {
                MessageBox.Show("数字太长了，显示不了啦！");
            }
            ss.Speak("点");
        }

        private void button12_Click(object sender, EventArgs e) //点击乘号
        {
            string lastmatch = "";

            Regex reg = new Regex(@"[\+|×|\-|÷|%]");
            MatchCollection matchs = reg.Matches(label2.Text);
            int matchcount = matchs.Count;
            if (matchcount > 0)
            {
                lastmatch = matchs[matchcount - 1].Value;//确定上一个运算符是什么
            }


            if (label1.Text.Length > 0)
            {

                string nowstring = label1.Text;
                label2.Text += nowstring + "×";

            }
            flag = 0;//修改标志值
            if (lastmatch == "+") //当上一个运算符为加号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Add(b, a);
                label1.Text = result.ToString();


            }
            if (lastmatch == "×") //当上一个运算符为乘号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Multi(b, a);
                label1.Text = result.ToString();
            }
            if (lastmatch == "-") //当上一个运算符为减号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Sub(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "÷") //当上一个运算符为除号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Divi(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "%") //当上一个运算符为求余号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Surplus(b, a);
                label1.Text = result.ToString();

            }
            lastnum = label1.Text;
            ss.Speak("乘");
        }

        private void button15_Click(object sender, EventArgs e) //点击减号
        {
            string lastmatch = "";

            Regex reg = new Regex(@"[\+|×|\-|÷|%]");
            MatchCollection matchs = reg.Matches(label2.Text);
            int matchcount = matchs.Count;
            if (matchcount > 0)
            {
                lastmatch = matchs[matchcount - 1].Value;//确定上一个运算符是什么
            }


            if (label1.Text.Length > 0)
            {

                string nowstring = label1.Text;
                label2.Text += nowstring + "-";

            }
            flag = 0;//修改标志值
            if (lastmatch == "+") //当上一个运算符为加号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Add(b, a);
                label1.Text = result.ToString();


            }
            if (lastmatch == "×") //当上一个运算符为乘号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Multi(b, a);
                label1.Text = result.ToString();
            }
            if (lastmatch == "-") //当上一个运算符为减号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Sub(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "÷") //当上一个运算符为除号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Divi(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "%") //当上一个运算符为求余号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Surplus(b, a);
                label1.Text = result.ToString();

            }
            lastnum = label1.Text;
            ss.Speak("减");
        }

        private void button11_Click(object sender, EventArgs e) //点击除号
        {
            string lastmatch = "";

            Regex reg = new Regex(@"[\+|×|\-|÷|%]");
            MatchCollection matchs = reg.Matches(label2.Text);
            int matchcount = matchs.Count;
            if (matchcount > 0)
            {
                lastmatch = matchs[matchcount - 1].Value;//确定上一个运算符是什么
            }


            if (label1.Text.Length > 0)
            {

                string nowstring = label1.Text;
                label2.Text += nowstring + "÷";

            }
            flag = 0;//修改标志值
            if (lastmatch == "+") //当上一个运算符为加号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Add(b, a);
                label1.Text = result.ToString();


            }
            if (lastmatch == "×") //当上一个运算符为乘号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Multi(b, a);
                label1.Text = result.ToString();
            }
            if (lastmatch == "-") //当上一个运算符为减号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Sub(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "÷") //当上一个运算符为除号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Divi(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "%") //当上一个运算符为求余号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Surplus(b, a);
                label1.Text = result.ToString();

            }
            lastnum = label1.Text;
            ss.Speak("除以");
        }

        private void button19_Click(object sender, EventArgs e) //点击求余号
        {
            string lastmatch = "";

            Regex reg = new Regex(@"[\+|×|\-|÷|%]");
            MatchCollection matchs = reg.Matches(label2.Text);
            int matchcount = matchs.Count;
            if (matchcount > 0)
            {
                lastmatch = matchs[matchcount - 1].Value;//确定上一个运算符是什么
            }


            if (label1.Text.Length > 0)
            {

                string nowstring = label1.Text;
                label2.Text += nowstring + "%";

            }
            flag = 0;//修改标志值
            if (lastmatch == "+") //当上一个运算符为加号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Add(b, a);
                label1.Text = result.ToString();


            }
            if (lastmatch == "×") //当上一个运算符为乘号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Multi(b, a);
                label1.Text = result.ToString();
            }
            if (lastmatch == "-") //当上一个运算符为减号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Sub(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "÷") //当上一个运算符为除号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Divi(b, a);
                label1.Text = result.ToString();

            }
            if (lastmatch == "%") //当上一个运算符为求余号时，先算出结果
            {

                Class1 myadd = new Class1();

                Double a = Convert.ToDouble(label1.Text);
                Double b = Convert.ToDouble(lastnum);
                Double result = myadd.Surplus(b, a);
                label1.Text = result.ToString();

            }
            lastnum = label1.Text;
        }

        private void button20_Click(object sender, EventArgs e) //平方
        {
            Class1 myadd = new Class1();

            Double a = Convert.ToDouble(label1.Text);
            
            Double result = myadd.Square(a);
            label1.Text = result.ToString();
            ss.Speak("平方");
            ss.Speak("等于"+label1.Text);
        }

        private void button21_Click(object sender, EventArgs e)//清除输入数据
        {
            label1.Text = "0";
            flag = 0;
        }

        private void button23_Click(object sender, EventArgs e) //隔开输入的方程参数
        {
            if (flag == 0)
            {
                label1.Text = "";

                flag = 1;
            }
            else
            {
                label1.Text += " ";

            }
        }

        private void button22_Click(object sender, EventArgs e)//解一元二次方程
        {
            Regex reg = new Regex(@"[0-9]+");
            MatchCollection matchs = reg.Matches(label1.Text);
            int matchcount = matchs.Count;
            String a = matchs[0].Value;
            String b = matchs[1].Value;
            String c = matchs[2].Value;
            label2.Text = a+"x²"+"+"+b+"x" +"+"+ c+"=0";
            Class1 myadd = new Class1();

            Double a1 = Convert.ToDouble(a);
            Double b1 = Convert.ToDouble(b);
            Double c1 = Convert.ToDouble(c);
            String result =myadd.Equation(a1, b1, c1);
            label1.Text = result;

        }
    }
}
