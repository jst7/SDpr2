﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace interfaz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.UtcNow;

            textBox3.Text = thisDay.ToString();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (leerusuarios())
            {
                RMI1.RMIStation rmi = new RMI1.RMIStation();
                this.Visible = false;
                Form1 inter = new Form1(textBox1.Text);
                inter.Show();
                
            }
            else {
                button1.Text = "Error";
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "Entra";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Text = "Entra";

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

           
            
        }
        private Boolean leerusuarios() {

           string line;
                    
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\" + Environment.UserName + "\\Desktop\\usuarios.txt");
            while ((line = file.ReadLine()) != null)   {
               
                if (line == textBox1.Text+"|"+textBox2.Text) {
                    file.Close();
                    return true;
                }
                
                
            }

            file.Close();
            return false;
        }
    }
}
