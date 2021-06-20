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
    public partial class ClienteControl1 : UserControl
    {
        public ClienteControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClienteControl1_Load(object sender, EventArgs e)
        {

        }
        //codice fiscale
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid miglior cliente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button visualizza miglior cliente
            sqlDataContext db = new sqlDataContext();
            var res = from c in db.CLIENTEs
                      select c;
            dataGridView1.DataSource = res;

        }

        //numero di telaio moto
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        //inserisci moto button
        private void button3_Click(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            MOTO add = new MOTO
            {
                Numero_telaio = int.Parse(textBox7.Text),
                Marca = comboBox2.Text,
                Modello = textBox9.Text,
                Cilindrata = int.Parse(comboBox1.Text),
                CF = textBox6.Text

            };
            db.MOTOs.InsertOnSubmit(add);
            db.SubmitChanges();

            textBox7.Text = " ";
            comboBox2.Text = " ";
            textBox9.Text = " ";
            comboBox1.Text = " ";
            textBox6.Text = " ";
        }

        //marca moto
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //modello moto
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        //cilindrata moto
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //nome cliente
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //cognome cliente
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //telefono cliente
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //mail cliente 
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //data cliente
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //inserisci cliente button
        private void button2_Click(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            CLIENTE add = new CLIENTE
            {
                CF = textBox1.Text,
                Nome = textBox2.Text,
                Cognome = textBox3.Text,
                Telefono = int.Parse(textBox4.Text),
                Mail = textBox5.Text,
                Data_di_nascita = dateTimePicker1.Value
            };
            db.CLIENTEs.InsertOnSubmit(add);
            db.SubmitChanges();

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";


        }
        // codice fiscale per moto
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
