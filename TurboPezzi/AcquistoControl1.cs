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
    public partial class AcquistoControl1 : UserControl
    {
        private decimal imp = 0;
        public AcquistoControl1()
        {
            InitializeComponent();
        }

        private void Acquisto_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //box p.iva fornitote

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button inserisci fornitore

            sqlDataContext db = new sqlDataContext();
            FORNITORE add = new FORNITORE
            {
                P_IVA = int.Parse(textBox1.Text),
                Nome_azienda = textBox2.Text,
                Mail = textBox5.Text,
                Telefono = int.Parse(textBox4.Text),
                Indirizzo = textBox7.Text             
            };
            db.FORNITOREs.InsertOnSubmit(add);
            db.SubmitChanges();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button inserisci prodotto
            sqlDataContext db = new sqlDataContext();          
            RICAMBIO ric = new RICAMBIO
            {
                Quantità_scorta = 0,
                CodiceRicambio = int.Parse(textBox10.Text),
                CodiceMagazzino = int.Parse(textBox3.Text),
                Categoria = comboBox1.Text,
                Descrizione = richTextBox1.Text,
                Marca = textBox9.Text
               
            };
            db.RICAMBIOs.InsertOnSubmit(ric);
            db.SubmitChanges();

            textBox10.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            richTextBox1.Text = "";
            textBox9.Text = "";

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcquistoControl1_Load(object sender, EventArgs e)
        {


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            sqlDataContext db = new sqlDataContext();                      
            
           
            

            db.SubmitChanges();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //fattura d'aquisto
        {


            var q = numericUpDown1.Value;
            var p = int.Parse(textBox6.Text);
            var iva = 1 + int.Parse(textBox13.Text);

            this.imp = (this.imp + (q * p)) + iva;
            

            sqlDataContext db = new sqlDataContext();
            FATTURA_DI_ACQUISTO fat = new FATTURA_DI_ACQUISTO
            {
                CodiceFatturaA = int.Parse(textBox11.Text),
                Data_emissione = dateTimePicker3.Value,
                Importo_netto = this.imp,
                IVA = int.Parse(textBox13.Text),
                P_IVA = int.Parse(textBox8.Text)
            };
            composizione_acquisto ca = new composizione_acquisto
            {
                CodiceRicambio = int.Parse(textBox12.Text),
                CodiceFatturaA = int.Parse(textBox11.Text),
                Prezzo_unitario = int.Parse(textBox6.Text),
                Quantità = numericUpDown1.Value

            };
            db.composizione_acquistos.InsertOnSubmit(ca);

            var queryRicambi = from ric in db.RICAMBIOs
                               where ric.CodiceRicambio.Equals(textBox12.Text)
                               select ric;
            foreach (RICAMBIO ric in queryRicambi) //aggiorno quantità scorta ric
            {
                ric.Quantità_scorta = ric.Quantità_scorta + ca.Quantità;

            }


            this.label28.ResetText();
            this.label28.Text = this.imp.ToString();
            db.FATTURA_DI_ACQUISTOs.InsertOnSubmit(fat);
            db.SubmitChanges();

            textBox11.Text = "";
            textBox13.Text = "";
            textBox8.Text = "";
            textBox12.Text = "";
            textBox6.Text = "";

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }
    }
}
