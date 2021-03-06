﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentación
{
    public partial class FrmConectarBD : Form
    {
        public FrmConectarBD()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            FrmPrincipal p = new FrmPrincipal();
            p.Show();
            this.Hide();
        }

        private void FrmConectarBD_Load(object sender, EventArgs e)
        {
            BtnAceptar.Visible = false;
            BtnCancelar.Visible = false;
            cboBases.Items.Add("prueba");

        }

        private void btnProbarConex_Click(object sender, EventArgs e)
        {
            if (txtServer.Text != ""&& cboBases.Text != "")
            {   
                    BtnAceptar.Visible = true;
                    BtnCancelar.Visible = true;
               
                
            }
            else
            {
                MessageBox.Show("Por favor ingresa datos para poder probar la conexion");
            }
        }
    }
}
