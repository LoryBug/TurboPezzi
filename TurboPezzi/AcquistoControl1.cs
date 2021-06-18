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
            //button inserisci fonritore

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
            RICAMBIO add = new RICAMBIO
            {
                CodiceRicambio = int.Parse(textBox10.Text),
                Marca = textBox9.Text,
                //da sistemare


            };
            db.RICAMBIOs.InsertOnSubmit(add);
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
    }
}
