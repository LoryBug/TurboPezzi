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
            var prod = from r in db.RICAMBIOs
                      where r.CodiceRicambio.Equals(textBox12.Text)
                      select r;
            List<decimal> ricambi = new List<decimal>(); //lista dei ricambi presenti nel db
            prod.ToList().ForEach(d => ricambi.Add(d.CodiceRicambio));


            /*var res = from r in db.RICAMBIOs
                      let c = from d in prod
                              select d.CodiceRicambio
                      where ricambi.Contains(r.CodiceRicambio) == false
                      select new { r.CodiceRicambio, r.Marca, r.Categoria, r.Quantità_scorta, r.Descrizione, r.CodiceMagazzino };*/             

            if (!prod.Any()){
                RICAMBIO r = new RICAMBIO();
                r.CodiceRicambio = int.Parse(textBox10.Text);
                r.Marca = textBox9.Text;
                r.Categoria = comboBox1.Text;
                r.CodiceMagazzino = int.Parse(textBox3.Text);
                r.Descrizione = richTextBox1.Text;
                r.Quantità_scorta = numericUpDown1.Value;
                db.RICAMBIOs.InsertOnSubmit(r);
            }
            else
            {
                
            }
            db.SubmitChanges();
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
            composizione_acquisto ca = new composizione_acquisto
                {
                    CodiceRicambio = int.Parse(textBox12.Text),
                    CodiceFatturaA = int.Parse(textBox11.Text),
                    Prezzo_unitario = int.Parse(textBox6.Text),
                    Quantità = numericUpDown1.Value

                };
            db.composizione_acquistos.InsertOnSubmit(ca);

            /*var queryRicambi = from p in db.RICAMBIOs
                               where p.CodiceRicambio.Equals(textBox10.Text)
                               select p;*/
            /*foreach(RICAMBIO ric in queryRicambi) //aggiorno quantità scorta ric
            {
                ric.Quantità_scorta = ric.Quantità_scorta + ca.Quantità;
                
            }*/
            var tot = ca.Quantità * ca.Prezzo_unitario;
            this.imp = tot;
            

            db.SubmitChanges();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e) //fattura d'aquisto
        {
            /*
             this.countImporto = this.countImporto + (c.Quantità * c.PrezzoUnitario);
             this.importoNetto.ResetText();
             this.importoNetto.Text = this.countImporto.ToString();*/
            sqlDataContext db = new sqlDataContext();
            FATTURA_DI_ACQUISTO fat = new FATTURA_DI_ACQUISTO
            {
                CodiceFatturaA = int.Parse(textBox11.Text),
                Data_emissione = dateTimePicker3.Value,
                Importo_netto = this.imp,
                IVA = int.Parse(textBox13.Text),
                P_IVA = int.Parse(textBox8.Text)
            };
            db.FATTURA_DI_ACQUISTOs.InsertOnSubmit(fat);
            this.imp = 0;

            // devo settare il textbox14 di importo netto come prezzo unitario per quantita
            
             //fat.Importo_netto
            db.SubmitChanges();

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
    }
}
