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
                Attivo = char.Parse(comboBox2.Text)           
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
    }
}