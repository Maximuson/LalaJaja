using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ArrRegList[0] = "asd";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        string login = "0";
        string password = "0";


         List<string> ArrRegList = new List<string>();
        
        
        

        string[] logArr = { "0", "1", "root" };
        string[] passArr = { "0", "2", "root" };
        
        bool  Login()
        {
            
            

            if (log.Text == login && pass.Text == password)
            {
                log.ForeColor = Color.Green;
                log.Text = "OK";
                pass.ForeColor = Color.Green;
                pass.Text = "OK";
                label1.Text = "вы в улане усиха";
                label2.Text = "ЧЕДОООРИИИ";
                return true;
            }
            else
            {
                label1.Text = "в клане Учиха такого нету";
                label2.Text = "не угадал";
                log.ForeColor = Color.Red;
                pass.ForeColor = Color.Red;
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0 ; i < logArr.Length; i++)
            {
                login = logArr[i];
                password = passArr[i];

                if (Login() == true )
                {
                    break;
                }
            }

           
            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            

        }
    }
}
