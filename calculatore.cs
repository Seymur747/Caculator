using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorF
{
    public partial class Form1 : Form
    {

        double  first;
        double second;
        double result;
        Button btn;
        Button operate;
        int count=1;
        int count2 = 1;
        

        public Form1()
        {
          
            InitializeComponent();
            count = 1;
            textBox1.ReadOnly = true;
            
        }

        private void b_click(object sender, EventArgs e)
        {

            
             btn = new Button();       
             btn = sender as Button;
            
            
            if (count==1)
            {
                textBox1.Text = textBox1.Text + btn.Text;
                first = Convert.ToDouble(textBox1.Text);
            }
            else if( count == 0) {
                textBox1.Text = textBox1.Text + btn.Text;
                second = Convert.ToDouble(textBox1.Text);
            }
          
        }

        private void O_click(object sender, EventArgs e)
        {
 
            if (first != Convert.ToDouble(null))
            {
                count = 0;
            }
            textBox1.Clear();
            operate = new Button();
            operate = sender as Button;
          
                                   
        }

        private void E_click(object sender, EventArgs e)
        {
            if (operate.Text=="+") {
                result = first + second;
            }

            if (operate.Text == "-")
            {
                result = first - second;
            }

            if (operate.Text == "X")
            {
                result = first * second;
            }
            if (operate.Text == "/")
            {
                result = first / second;
            }
            if (operate.Text=="%") {
                result = first / 100;
            }

          
            textBox1.Text =(result.ToString()) ;
            if (textBox1.Text != null&&result!=Convert.ToDouble (null)) {

                first = result;
                count = 0;

            }


        }

        private void C_click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(null) ;
            second = Convert.ToDouble(null);
            textBox1.Clear();
            textBox1.Text = null;
            count = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void DeleteD_click(object sender, EventArgs e)
        //{
        //    textBox1.Text = (Convert.ToDouble(textBox1.Text) / 10).ToString();
        //    if (first != Convert.ToDouble(null)) {

        //        first = Convert.ToDouble(textBox1.Text);

        //    }

        //}
    }
}
