using POO23A_MA.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO23A_MA
{
    public partial class DlgBienvenida : Form
    {
        public DlgBienvenida()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PbxMenuQuimica_Click(object sender, EventArgs e)
        {
            DlgPrincipal DlgPrincipal = new DlgPrincipal();
            DlgPrincipal.Show();
            this.Close();
        }

        private void PbxMenuCalendario_Click(object sender, EventArgs e)
        {
            DlgPrincipalCalendario DlgPrincipalCalendario = new DlgPrincipalCalendario();
            DlgPrincipalCalendario.Show();
            this.Close();
        }

        private void PbxMenuSistemaSolar_Click(object sender, EventArgs e)
        {
            DlgPrincipalSistemaSolar DlgPrincipalSistemaSolar = new DlgPrincipalSistemaSolar();
            DlgPrincipalSistemaSolar.Show();
            this.Close();
        }

        private void PbxMenuQuimica_MouseEnter(object sender, EventArgs e)
        {
            LblNombreMenu.ForeColor = Color.Green;
            LblNombreMenu.Text = "Tabla Periódica";
            PbxMenuQuimica.Location = new Point(165, 102);
        }

        private void PbxMenuQuimica_MouseLeave(object sender, EventArgs e)
        {
            LblNombreMenu.Text = "";
            PbxMenuQuimica.Location = new Point(165, 107);
        }

        private void PbxMenuCalendario_MouseEnter(object sender, EventArgs e)
        {
            LblNombreMenu.ForeColor = Color.Yellow;
            LblNombreMenu.Text = "Calendario";
            PbxMenuCalendario.Location = new Point(46, 102);
        }

        private void PbxMenuCalendario_MouseLeave(object sender, EventArgs e)
        {
            LblNombreMenu.Text = "";
            PbxMenuCalendario.Location = new Point(46, 107);
        }

        private void PbxMenu3_MouseEnter(object sender, EventArgs e)
        {
            LblNombreMenu.ForeColor = Color.Orange;
            LblNombreMenu.Text = "Sistema Solar";
            PbxMenuSistemaSolar.Location = new Point(278, 102);
        }

        private void PbxMenu3_MouseLeave(object sender, EventArgs e)
        {
            LblNombreMenu.Text = "";
            PbxMenuSistemaSolar.Location = new Point(278, 107);
        }
    }
}
