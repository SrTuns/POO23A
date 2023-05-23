using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace POO23A_MA
{
    //-------------------------------------------------------------------------
    //Diálogo de la práctica 2.
    //MA. 02/05/2023.
    //-------------------------------------------------------------------------
    public partial class DlgPractica2 : Form
    {
        //-------------------------------------------------------------------------
        //Atributos.
        //-------------------------------------------------------------------------
        private int Velocidad;
        private Thread ProcesoColision;
        private bool Colision;
        private List<CZombie>Zombies = new List<CZombie>();

        //-------------------------------------------------------------------------
        //Constructor.
        //-------------------------------------------------------------------------
        public DlgPractica2()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Colision = false;

            Velocidad = 0;
        }

        //-------------------------------------------------------------------------
        //Crea un zombie.
        //-------------------------------------------------------------------------
        private void BtnZombie_Click(object sender, EventArgs e)
        {
            CZombieComun Zombie;

            Zombie = new CZombieComun(this.PbxFondo);
            Zombie.Nacer();
            Velocidad = 70;

            if (!Zombie.IsDisposed)
            {
                Zombie.Desplazar(Velocidad);
                PbxFondo.Refresh();
                Zombies.Add(Zombie);
            }
        }

        //-------------------------------------------------------------------------
        //Crea un zombie romero.
        //-------------------------------------------------------------------------
        private void BtnZombieRomero_Click(object sender, EventArgs e)
        {
            CZombieRomero Zombie;

            Zombie = new CZombieRomero(this.PbxFondo);
            Zombie.Nacer();
            Velocidad = 40;
            if (!Zombie.IsDisposed)
            {
                Zombie.Desplazar(Velocidad);
                PbxFondo.Refresh();
                Zombies.Add(Zombie);
            }
        }

        private void BtnZombieWitch_Click(object sender, EventArgs e)
        {
            CZombieWitch Zombie;

            Zombie = new CZombieWitch(this.PbxFondo);
            Zombie.Nacer();
            Velocidad = 10;
            if (!Zombie.IsDisposed)
            {
                Zombie.Desplazar(Velocidad);
                PbxFondo.Refresh();
                Zombies.Add(Zombie);
            }
        }

        //-------------------------------------------------------------------------
        //Inicial el proceso de verificación de colision.
        //-------------------------------------------------------------------------
        private void BtnColision_Click(object sender, EventArgs e)
        {
            ProcesoColision = new Thread(() =>
            {
                int[] Localizacion;
                int[] Localizacion2;

                Colision = true;

                Localizacion = new int[4];
                Localizacion2 = new int[4];

                while (Colision)
                {
                    //Etapa 1: Obtiene coordenadas y procesa el color.
                    Control[] ControlsCopia = this.PbxFondo.Controls.Cast<Control>().ToArray();


                    foreach (Control Control in ControlsCopia)
                    {
                        if (Control is CZombieComun || Control is CZombieRomero || Control is CZombieWitch)
                        {
                            CZombie Zombie;
                            Zombie = (CZombie)Control;
                            Localizacion = Zombie.GetAreaLocalizacion();
                            if (!Zombie.IsDisposed)
                            {
                                Thread.Sleep(500);
                                //Zombie.BackColor = Color.GreenYellow;
                                Zombie.Text = Localizacion[0].ToString() + "," + Localizacion[1].ToString();
                                Thread.Sleep(500);
                                //Zombie.BackColor = Color.Yellow;
                                Zombie.Text = Localizacion[0].ToString() + "," + Localizacion[1].ToString();
                            }
                            Zombies.Add(Zombie);
                        }
                    }

                    //Etapa 2: Compara coordenadas y crea colisión.

                    for (int i = 0; i < Zombies.Count - 1; i++)
                    {
                        CZombie ZombieA = Zombies[i];

                        for (int j = i + 1; j < Zombies.Count; j++)
                        {
                            CZombie ZombieB = Zombies[j];

                            Localizacion = ZombieA.GetAreaLocalizacion();
                            Localizacion2 = ZombieB.GetAreaLocalizacion();

                            int Z1X1, Z1Y1, Z1X2, Z1Y2;
                            int Z2X1, Z2Y1, Z2X2, Z2Y2;

                            Z1X1 = Localizacion[0];
                            Z1Y1 = Localizacion[1];
                            Z1X2 = Localizacion[2];
                            Z1Y2 = Localizacion[3];

                            Z2X1 = Localizacion[0];
                            Z2Y1 = Localizacion[1];
                            Z2X2 = Localizacion[2];
                            Z2Y2 = Localizacion[3];

                            if (Localizacion[0] < Localizacion2[2] && Localizacion[2] > Localizacion2[0] &&
                            Localizacion[1] < Localizacion2[3] && Localizacion[3] > Localizacion2[1])
                                {
                                if ((ZombieA is CZombieComun && ZombieB is CZombieRomero) || (ZombieB is CZombieComun && ZombieA is CZombieRomero))
                                {
                                    CZombieComun ZombieC = ZombieA is CZombieComun ? (CZombieComun)ZombieA : (CZombieComun)ZombieB;
                                    CZombieRomero ZombieR = ZombieA is CZombieRomero ? (CZombieRomero)ZombieA : (CZombieRomero)ZombieB;

                                    // Mostrar el mensaje de colisión en el hilo principal
                                    //Invoke((Action)(() =>
                                    //{
                                        ZombieC.Morir(); // Matar zombie común
                                        PbxFondo.Controls.Remove(ZombieC);
                                        PbxFondo.Refresh(); // Actualizar fondo
                                    //}));
                                }

                                if ((ZombieA is CZombieComun && ZombieB is CZombieWitch) || (ZombieB is CZombieComun && ZombieA is CZombieWitch))
                                {
                                    CZombieComun ZombieC = ZombieA is CZombieComun ? (CZombieComun)ZombieA : (CZombieComun)ZombieB;
                                    CZombieWitch ZombieWitch = ZombieA is CZombieWitch ? (CZombieWitch)ZombieA : (CZombieWitch)ZombieB;

                                    // Mostrar el mensaje de colisión en el hilo principal

                                    //Invoke((Action)(() =>
                                    //{
                                        ZombieC.Morir(); // Destruir CZombiePasivo
                                        PbxFondo.Controls.Remove(ZombieC);
                                        PbxFondo.Refresh(); // Actualizar el PictureBox
                                    //}));
                                }

                                if ((ZombieA is CZombieRomero && ZombieB is CZombieWitch) || (ZombieB is CZombieRomero && ZombieA is CZombieWitch))
                                {
                                    CZombieRomero ZombieRomero = ZombieA is CZombieRomero ? (CZombieRomero)ZombieA : (CZombieRomero)ZombieB;
                                    CZombieWitch ZombieWitch = ZombieA is CZombieWitch ? (CZombieWitch)ZombieA : (CZombieWitch)ZombieB;

                                    // Mostrar el mensaje de colisión en el hilo principal
                                    //Invoke((Action)(() =>
                                    //{
                                        ZombieRomero.Morir(); // Destruir CZombiePasivo
                                        PbxFondo.Controls.Remove(ZombieRomero);
                                        PbxFondo.Refresh(); // Actualizar el PictureBox
                                    //}));
                                }

                            }

                        }

                        bool Restantes;

                        Restantes = false;

                        foreach (Control Control in ControlsCopia)
                        {
                            if (Control is CZombieComun || Control is CZombieRomero || Control is CZombieWitch)
                            {
                                Restantes = true;
                                break;
                            }
                        }

                        if (!Restantes)
                        {
                            Colision = false;
                        }
                    }
                };
                ProcesoColision.Start();
            });
            }
    }
}
