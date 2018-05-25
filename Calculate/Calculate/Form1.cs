using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  

        }

      


        public void plus(int Lala, int Jaja)
        {
            int first = Convert.ToInt32(txtFirst.Text);
            int second = Convert.ToInt32(txtSecond.Text);
            int result = 0;
            Lala = first;
            Jaja = second;
            result = Lala + Jaja;
            txtResult.Text = result.ToString();
        }

        string minus()
        {
            
             
            int result = 0;
            int   Lala = Convert.ToInt32(txtFirst.Text);
            int  Jaja = Convert.ToInt32(txtSecond.Text);
            result = Lala - Jaja;
            txtResult.Text = result.ToString();
            return result.ToString();
        }

        private void bttnPlus_Click(object sender, EventArgs e)
        {
            plus(0, 0); //бесполезные нули
        }

        private void bttnMinus_Click(object sender, EventArgs e)
        {
            minus();
        }
    }
}
