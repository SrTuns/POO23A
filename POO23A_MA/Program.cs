using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POO23A_MA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ApplicationConfiguration.Initialize();

            //DlgPrincipal MiVentana;
            //MiVentana = new DlgPrincipal();
            //MiVentana.Maximizar();

            DlgPrincipal main = new DlgPrincipal();
            main.FormClosed += MainForm_Closed;
            main.Show();

            //Application.Run(MiVentana);
            Application.Run();
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}