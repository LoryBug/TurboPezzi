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
    public partial class VenditaControl1 : UserControl
    {
        public VenditaControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void VenditaControl1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button inserimento vendita
            sqlDataContext db = new sqlDataContext();
            VENDITA add = new VENDITA
            {
                CodiceFatturaV = int.Parse(textBox1.Text),
                CodiceVendita = int.Parse(textBox2.Text),
                CodiceImpiegato = int.Parse(textBox4.Text),
                


                


            };
            db.VENDITAs.InsertOnSubmit(add);
            db.SubmitChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //button calcola ricavi
           /* sqlDataContext db = new sqlDataContext();
            RICAMBIO add = new RICAMBIO
            {
                CodiceRicambio = int.Parse(textBox10.Text),
                Marca = textBox9.Text,
                //da sistemare


            };
            db.RICAMBIOs.InsertOnSubmit(add);
            db.SubmitChanges();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //button visualizza ricambi più venduti
           /* var res = select v.CodiceImpiegato, COUNT(*) as vendite
                        from VENDITA as v
                        group by v.CodiceImpiegato
          */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid ricambi più venduti
        }

        private void button2_Click(object sender, EventArgs e)
        { //inserimento dettaglio d'ordine

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
