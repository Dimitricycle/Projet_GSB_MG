﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3GSB_MG
{
    public partial class FormRapportVisit : Form
    {
        public FormRapportVisit()
        {
            InitializeComponent();
        }

        private void FormRapportVisit_Load(object sender, EventArgs e)
        {
            bsInformationVisite.DataSource = Modele.ListeRapport();
            //textBoxRapportVisit.Text = bsInformationVisite;
        }
    }
}