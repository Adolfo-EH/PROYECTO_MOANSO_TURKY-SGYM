﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turky_sGym_Programa
{
    public partial class CRUD_Marca : Form
    {
        public CRUD_Marca()
        {
            InitializeComponent();
            gbMarca.Enabled = false;
        }

        private void Marca_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearM_Click(object sender, EventArgs e)
        {
            gbMarca.Enabled = true;
        }
    }
}
