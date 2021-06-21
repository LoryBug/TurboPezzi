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
        private decimal imp = 0;
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
            var q = numericUpDown1.Value;
            var p = int.Parse(textBox6.Text);
            var iva = 1 + (int.Parse(textBox5.Text));

            this.imp = (q * p)+iva;

            VENDITA add = new VENDITA
            {
                CodiceFatturaV = int.Parse(textBox1.Text),
                CodiceVendita = int.Parse(textBox2.Text),
                CodiceImpiegato = int.Parse(textBox4.Text),
                Descrizione = richTextBox1.Text
            };
            db.VENDITAs.InsertOnSubmit(add);


            FATTURA_DI_VENDITA fv = new FATTURA_DI_VENDITA
            {
                CodiceFatturaV = int.Parse(textBox1.Text),
                Data_emissione = dateTimePicker1.Value,
                Importo_netto = this.imp,
                IVA = int.Parse(textBox5.Text),
                CF = textBox3.Text
            };
            db.FATTURA_DI_VENDITAs.InsertOnSubmit(fv);

            DETTAGLIO_ORDINE dt = new DETTAGLIO_ORDINE
            {
                CodiceImpiegato = int.Parse(textBox4.Text),
                Numero_ordine = int.Parse(textBox8.Text),
                CodiceRicambio = int.Parse(textBox6.Text),
                CodiceVendita = int.Parse(textBox2.Text),
                Quantità = numericUpDown1.Value,
                Prezzo_unitario = int.Parse(textBox7.Text)
            };

            foreach (RICAMBIO ric in db.RICAMBIOs)
            {
                if (ric.CodiceRicambio == int.Parse(textBox6.Text))
                {
                    ric.Quantità_scorta = ric.Quantità_scorta - numericUpDown1.Value;
                }
            }

            db.DETTAGLIO_ORDINEs.InsertOnSubmit(dt);
            db.SubmitChanges();
            this.label3.ResetText();
            this.label3.Text = this.imp.ToString();

           

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            richTextBox1.Text = " ";
            label3.Text = "";
            this.imp = 0;
            


        }


        private void button4_Click(object sender, EventArgs e)
        { //ricambio più venduto
          // var queryRic = from
          //button visualizza ricambi più venduti
            sqlDataContext db = new sqlDataContext();

            var query = (from det in db.DETTAGLIO_ORDINEs
                          join p in db.RICAMBIOs on det.CodiceRicambio equals p.CodiceRicambio
                         group det by det.CodiceRicambio into m
                         let tot = m.Sum(i => i.Quantità)
                         orderby tot descending
                         select new { tot}).Take(3);

            var queryBest = from det in db.DETTAGLIO_ORDINEs
                           join p in db.RICAMBIOs on det.CodiceRicambio equals p.CodiceRicambio                           
                           group det by new { det.CodiceRicambio, p.Categoria } into m
                           let tot = m.Sum(i => i.Quantità)
                           where tot == query.First().tot
                           select new { m.Key.CodiceRicambio, m.Key.Categoria, tot };
            dataGridView1.DataSource = queryBest;

            
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
