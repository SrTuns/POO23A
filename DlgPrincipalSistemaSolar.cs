using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO23A_MA.Menus
{
    public partial class DlgPrincipalSistemaSolar : Form
    {
        public DlgPrincipalSistemaSolar()
        {
            InitializeComponent();
        }

        private void BtnSeleccionarMenu_Click(object sender, EventArgs e)
        {
            DlgBienvenida DlgBienvenida = new DlgBienvenida();
            DlgBienvenida.Show();
            this.Close();
        }
    }
}
