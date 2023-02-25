using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POO23A_MA
{
    public partial class DlgConfigurar : Form
    {
        public DlgConfigurar()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //StreamWriter outputFile;

            //outputFile = new StreamWriter("C:\\Users\\PC\\Documents\\Universidad\\3er Semestre\\Programación Orientada a Objetos\\Descripciones\\" + CbxEscogerPractica.Text + ".txt");

            //string[] lineas = {
            //    TbxDescripcion.Text};

            //foreach (string linea in lineas)
            //{
            //    outputFile.WriteLine(linea);
            //}

            //outputFile.Close();

            //MessageBox.Show("Descripción guardada.");

            //TbxDescripcion.Text = "";

            //string fileName = Properties.Resources.Desc1;
            //string text = TbxDescripcion.Text;

            //using (StreamWriter writer = new StreamWriter(fileName))
            //{
            //    writer.Write(text);
            //}

            string fileName = "Desc1.txt"; // aquí debes proporcionar el nombre de archivo deseado
            string text = TbxDescripcion.Text;

            using (Stream stream = (Stream)Properties.Resources.ResourceManager.GetObject("Desc1"))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.Write(text);
            }

        }

        private void TbxDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //StreamWriter outputFile;

                //outputFile = new StreamWriter("C:\\Users\\PC\\Documents\\Universidad\\3er Semestre\\Programación Orientada a Objetos\\Descripciones\\" + CbxEscogerPractica.Text + ".txt");

                //string[] lineas = {
                //TbxDescripcion.Text};

                //foreach (string linea in lineas)
                //{
                //    outputFile.WriteLine(linea);
                //}

                //outputFile.Close();

                //MessageBox.Show("Descripción guardada.");

                //TbxDescripcion.Text = "";
            }
        }
    }
}
