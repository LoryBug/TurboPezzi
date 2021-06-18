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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textboxe nome
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textboxe cognome
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //textboxe telefono
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //textboxe mail
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //data selector
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button inserisci cliente
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //text numero telaio
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tendina marca
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            //textbox modello moto
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tendina cilindrata
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button inserisci moto
        }
    }
}
