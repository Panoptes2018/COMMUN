﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxCode.Text = "";
            textBoxMail.Text = "";
            textBoxMDP.Text = "";
        }
    }
}
