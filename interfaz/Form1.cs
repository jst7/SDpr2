using System;
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
    public partial class Form1 : Form
    {
        public Form1(string s)
        {
            InitializeComponent();

            DateTime thisDay = DateTime.UtcNow + TimeSpan.FromHours(1);
            comboBox3.Items.Add("Usuario " + s);
            escribir("Usuario " + s);
            comboBox3.Items.Add("Entramos al programa " + thisDay.ToString());
            escribir("Entramos al programa " + thisDay.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RMI1.RMIStation rmi = new RMI1.RMIStation();

            try
            {
                rmi.Url = "http://" + textBox1.Text + "/practica2sd/services/RMIStation?wsdl";
                rmi.GetHumedad();
                comboBox3.Items.Add(textBox1.Text + " Maquina valida");
                escribir(textBox1.Text + " Maquina valida");
                String result = textBox1.Text;

                richTextBox1.Text += textBox1.Text + "\n";
            }
            catch (Exception) {
                comboBox3.Items.Add(textBox1.Text + " Máquina invalida");
                escribir(textBox1.Text + " Máquina invalida");
            }
            



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RMI1.RMIStation rmi = new RMI1.RMIStation();

            try
            {
                rmi.Url = "http://" + comboBox2.Text + "/practica2sd/services/RMIStation?wsdl"; ;
                String pantalla = textBox3.Text;

                rmi.SetPantalla(pantalla);
                textBox3.Text = "Pantalla cambiada";
                comboBox3.Items.Add(comboBox2.Text + "Pantalla cambiada");
                escribir(comboBox2.Text + "Pantalla cambiada");
            }
            catch (Exception) {
                textBox3.Text = "Error";
                comboBox3.Items.Add("error en la escritura maquina " + comboBox2.Text + "\n");
                escribir("error en la escritura maquina " + comboBox2.Text + "\n");
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
         
        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RMI1.RMIStation rmi = new RMI1.RMIStation();

            String s=comboBox1.Text;
            rmi.Url = "http://" + comboBox2.Text + "/practica2sd/services/RMIStation?wsdl";
            switch (s) {

                case "Luminosidad": richTextBox2.Text = "el valor de luminosidad de la estación " + comboBox2.Text + " es:" + rmi.Getluminosidad();
                    comboBox3.Items.Add("Consultado Luminosidad de maquina: " + comboBox2.Text + " " + rmi.Getluminosidad());
                    escribir("Consultado Luminosidad de maquina: " + comboBox2.Text + " " + rmi.Getluminosidad());
                    break;
                case "Pantalla": richTextBox2.Text = "el valor de pantalla de la estación " + comboBox2.Text + " es:" + rmi.GetPantalla();
                    comboBox3.Items.Add("Consultado Pantalla de maquina: " + comboBox2.Text + " " + rmi.GetPantalla());
                    escribir("Consultado Pantalla de maquina: " + comboBox2.Text + " " + rmi.GetPantalla());
                    break;
                case "Humedad": richTextBox2.Text = "el valor de humedad de la estación " + comboBox2.Text + " es:" + rmi.GetHumedad();
                    comboBox3.Items.Add("Consultado Humedad de maquina: " + comboBox2.Text + " " + rmi.GetHumedad());
                    escribir("Consultado Humedad de maquina: " + comboBox2.Text + " " + rmi.GetHumedad());
                    break;
                case "Temperatura": richTextBox2.Text = "el valor de temperatura de la estación " + comboBox2.Text + " es:" + rmi.GetTemperatura();
                    comboBox3.Items.Add("Consultado Temperatura de maquina: " + comboBox2.Text + " " + rmi.GetTemperatura());
                    escribir("Consultado Temperatura de maquina: " + comboBox2.Text + " " + rmi.GetTemperatura());
                    break;

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            RMI1.RMIStation rmi = new RMI1.RMIStation();//Creamos objetos del servicio

            try//Usamos el try por si la maquina no existe que no se apague y mande un mensaje al registro
            {
                textBox2.Text = "http://" + comboBox2.Text + "/practica2sd/services/RMIStation?wsdl";
                rmi.Url = "http://" + comboBox2.Text + "/practica2sd/services/RMIStation?wsdl";//añadimos la URL y si no conecta dara excepcion
                escribir(comboBox2.Text +"añadimos"+ "\n");
            }catch(Exception){//Si no existe se envia un mensaje al registro
                comboBox3.Items.Add( "error en la maquina: " + comboBox2.Text + "\n");
                escribir("error en la maquina: " + comboBox2.Text + "\n");
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void escribir(String linealog) {

            // Compose a string that consists of three lines.
            DateTime thisDay = DateTime.UtcNow + TimeSpan.FromHours(1);
            string lines =" log: "+thisDay.ToString()+"_  " + linealog;
            System.IO.StreamWriter file;

            try
            {
                // Write the string to a file.
                file = new System.IO.StreamWriter("C:\\Users\\" + Environment.UserName + "\\Desktop\\log.txt", true);
                file.WriteLine(lines);
                file.Close();
            }catch(Exception){
                Console.WriteLine("No se puede acceder a la ruta: " + "C:\\Users\\" + Environment.UserName + "\\Desktop\\log.txt");
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
