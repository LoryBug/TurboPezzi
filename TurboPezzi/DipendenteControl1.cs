﻿using System;
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
    public partial class DipendenteControl1 : UserControl
    {
        public DipendenteControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DipendenteControl1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        //codice fiscale 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //inserisci dipendente button
        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            char att = '0' ;
            if (comboBox2.Text.Equals("Attivo"))
            {
                att = '1';
            }

>>>>>>> e8012b1fb9f2ffca320f10cac48c2d19611a23f5
            sqlDataContext db = new sqlDataContext();
            DIPENDENTE add = new DIPENDENTE
            {
                CF = textBox1.Text,
                Nome = textBox2.Text,
                Cognome = textBox3.Text,
                Telefono = int.Parse(textBox4.Text),
                Mail = textBox5.Text,
                Data_di_nascita = dateTimePicker1.Value,
                CodiceImpiegato = int.Parse(textBox7.Text),
<<<<<<< HEAD
                Attivo = char.Parse(comboBox2.Text)           
=======
                Attivo = att
>>>>>>> e8012b1fb9f2ffca320f10cac48c2d19611a23f5
            };
            db.DIPENDENTEs.InsertOnSubmit(add);
            db.SubmitChanges();

        }
        //nome dipendente
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //cognome
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //telefono
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //mail
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //datat nascita
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //codice impiegato
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //inserisci contratto 
        private void button4_Click(object sender, EventArgs e)
        {
            sqlDataContext db = new sqlDataContext();
            CONTRATTO add = new CONTRATTO
            {
                CodiceImpiegato = int.Parse(textBox6.Text),
                CodiceContratto = int.Parse(textBox1.Text),
                Tipologia = comboBox1.Text,
                Data_assunzione = dateTimePicker3.Value,
                Data_Termine = dateTimePicker2.Value,
                Stipendio = int.Parse(comboBox3.Text)

            };
            db.CONTRATTOs.InsertOnSubmit(add);
            db.SubmitChanges();

        }
        // codice contratto 
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        //tipologia contratto
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // data assunzione
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
        //data termine
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        //stipendio
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //rimuovere dipendente 
        private void button3_Click(object sender, EventArgs e)
        {
            // leggo codice impiegato
            // aggiorno lo stato di dipendente 
           
            sqlDataContext db = new sqlDataContext();
            
            db.SubmitChanges();
        }
        //codice per rimuovere dipendente
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
