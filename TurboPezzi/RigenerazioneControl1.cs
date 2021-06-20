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
    public partial class RigenerazioneControl1 : UserControl
    {
        public RigenerazioneControl1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
        //codice rigenerazione
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //aggiungi rigenerazione button
        private void button1_Click(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            RIGENERAZIONE add = new RIGENERAZIONE
            {
                CodiceRigenerazione = int.Parse(textBox1.Text),
                Data_rilascio = dateTimePicker1.Value,
                Descrizione = richTextBox1.Text, 
                CodiceFatturaV = int.Parse(textBox3.Text),
                CodiceImpiegato = int.Parse(textBox2.Text)

            };
            db.RIGENERAZIONEs.InsertOnSubmit(add);
            db.SubmitChanges();
        }

        //rigenerazione
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //descrizione
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //codice fattura 
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //codice impiegato
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
