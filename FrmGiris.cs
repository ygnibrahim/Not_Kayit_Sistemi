﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmÖğrenciDetay frm=new FrmÖğrenciDetay();
            frm.numara = maskedTextBox1.Text;
            frm.Show();
        }

       

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1125")
            {
                FrmÖğretmenDetay fr=new FrmÖğretmenDetay();
                fr.Show();
            }
        }
    }
}
