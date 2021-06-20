using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboPezzi
{
    public partial class Form1 : Form
    {

    
        public Form1()
        {
            InitializeComponent();
            //Disable all User button
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            
            
        }

        public void changeButton() {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
  
            //hide other controls
            clienteControl11.Hide();
            dipendenteControl11.Hide();
            rigenerazioneControl11.Hide();
            acquistoControl11.Hide();
            venditaControl11.Hide();
            magazzinoControl11.Hide();

        }

        //Cliente 
        private void button1_Click(object sender, EventArgs e)
        {
            //Hide other controls
           
            dipendenteControl11.Hide();
            rigenerazioneControl11.Hide();
            acquistoControl11.Hide();
            venditaControl11.Hide();
            magazzinoControl11.Hide();

            //show current control
            clienteControl11.Show();
            clienteControl11.BringToFront();

        }

 
        //Dipendente
        private void button2_Click(object sender, EventArgs e)
        {
            //Hide other controls
            
            clienteControl11.Hide();
            rigenerazioneControl11.Hide();
            acquistoControl11.Hide();
            venditaControl11.Hide();
            magazzinoControl11.Hide();

            //show current control
            dipendenteControl11.Show();
            dipendenteControl11.BringToFront();

        }

        //Rigenerazione
        private void button3_Click(object sender, EventArgs e)
        {

            //Hide other controls
           
            dipendenteControl11.Hide();
            clienteControl11.Hide();
            acquistoControl11.Hide();
            venditaControl11.Hide();
            magazzinoControl11.Hide();

            //show current control
            rigenerazioneControl11.Show();
            rigenerazioneControl11.BringToFront();

        }

        //Vendita
        private void button4_Click(object sender, EventArgs e)
        {
            //Hide other controls
           
            dipendenteControl11.Hide();
            rigenerazioneControl11.Hide();
            acquistoControl11.Hide();
            clienteControl11.Hide();
            magazzinoControl11.Hide();

            //show current control
            venditaControl11.Show();
            venditaControl11.BringToFront();

        }

        //acuisto
        private void button5_Click(object sender, EventArgs e)
        {

            //Hide other controls
            
            dipendenteControl11.Hide();
            rigenerazioneControl11.Hide();
            clienteControl11.Hide();
            venditaControl11.Hide();
            magazzinoControl11.Hide();

            //show current control
            acquistoControl11.Show();
            acquistoControl11.BringToFront();

        }

        //magazzino
        private void button6_Click(object sender, EventArgs e)
        {
            //Hide other controls
            
            dipendenteControl11.Hide();
            rigenerazioneControl11.Hide();
            acquistoControl11.Hide();
            venditaControl11.Hide();
            clienteControl11.Hide();

            //show current control
            magazzinoControl11.Show();
            magazzinoControl11.BringToFront();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //user name 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //password 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //login
        private void button7_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("admin"))
            {
                button7.Text = "Log In: Successful";
                button7.Enabled = false;
                changeButton();
            }
            else
            {
                button7.Text = "Log In: Failed";
            }
        }
    }
}
