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
    public partial class MagazzinoControl1 : UserControl
    {
        public MagazzinoControl1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //griglia ricambi per categoria
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            MAGAZZINO add = new MAGAZZINO
            {
                CodiceMagazzino = int.Parse(textBox1.Text),
                Indirizzo = textBox4.Text,
                Corsia = numericUpDown1.Value

            };
            db.MAGAZZINOs.InsertOnSubmit(add);
            db.SubmitChanges();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //visualizza ricambio scadenza
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //griglia ricambi in scadenza
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tendina categoria
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bottone visualizza ricambi per categoria
        }
    }
}
