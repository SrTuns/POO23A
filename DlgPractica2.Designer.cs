namespace POO23A_MA
{
    partial class DlgPractica2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgPractica2));
            this.BtnZombie = new System.Windows.Forms.Button();
            this.PnlLateral = new System.Windows.Forms.Panel();
            this.BtnZombieRomero = new System.Windows.Forms.Button();
            this.PbxFondo = new System.Windows.Forms.PictureBox();
            this.PnlSuperior = new System.Windows.Forms.Panel();
            this.BtnColision = new System.Windows.Forms.Button();
            this.BtnZombieWitch = new System.Windows.Forms.Button();
            this.PnlLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondo)).BeginInit();
            this.PnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnZombie
            // 
            this.BtnZombie.Location = new System.Drawing.Point(6, 50);
            this.BtnZombie.Name = "BtnZombie";
            this.BtnZombie.Size = new System.Drawing.Size(41, 38);
            this.BtnZombie.TabIndex = 0;
            this.BtnZombie.Text = "Z";
            this.BtnZombie.UseVisualStyleBackColor = true;
            this.BtnZombie.Click += new System.EventHandler(this.BtnZombie_Click);
            // 
            // PnlLateral
            // 
            this.PnlLateral.BackColor = System.Drawing.Color.Red;
            this.PnlLateral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlLateral.BackgroundImage")));
            this.PnlLateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlLateral.Controls.Add(this.BtnZombieWitch);
            this.PnlLateral.Controls.Add(this.BtnZombieRomero);
            this.PnlLateral.Controls.Add(this.BtnZombie);
            this.PnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLateral.Location = new System.Drawing.Point(0, 0);
            this.PnlLateral.Name = "PnlLateral";
            this.PnlLateral.Size = new System.Drawing.Size(50, 407);
            this.PnlLateral.TabIndex = 1;
            // 
            // BtnZombieRomero
            // 
            this.BtnZombieRomero.Location = new System.Drawing.Point(6, 94);
            this.BtnZombieRomero.Name = "BtnZombieRomero";
            this.BtnZombieRomero.Size = new System.Drawing.Size(41, 38);
            this.BtnZombieRomero.TabIndex = 1;
            this.BtnZombieRomero.Text = "ZR";
            this.BtnZombieRomero.UseVisualStyleBackColor = true;
            this.BtnZombieRomero.Click += new System.EventHandler(this.BtnZombieRomero_Click);
            // 
            // PbxFondo
            // 
            this.PbxFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbxFondo.Image = global::POO23A_MA.Properties.Resources.R1;
            this.PbxFondo.Location = new System.Drawing.Point(50, 50);
            this.PbxFondo.Name = "PbxFondo";
            this.PbxFondo.Size = new System.Drawing.Size(738, 357);
            this.PbxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxFondo.TabIndex = 2;
            this.PbxFondo.TabStop = false;
            // 
            // PnlSuperior
            // 
            this.PnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PnlSuperior.BackgroundImage = global::POO23A_MA.Properties.Resources.Mesa_de_trabajo_1_1001;
            this.PnlSuperior.Controls.Add(this.BtnColision);
            this.PnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSuperior.Location = new System.Drawing.Point(50, 0);
            this.PnlSuperior.Name = "PnlSuperior";
            this.PnlSuperior.Size = new System.Drawing.Size(738, 50);
            this.PnlSuperior.TabIndex = 3;
            // 
            // BtnColision
            // 
            this.BtnColision.Location = new System.Drawing.Point(582, 9);
            this.BtnColision.Name = "BtnColision";
            this.BtnColision.Size = new System.Drawing.Size(85, 38);
            this.BtnColision.TabIndex = 2;
            this.BtnColision.Text = "Colision";
            this.BtnColision.UseVisualStyleBackColor = true;
            this.BtnColision.Click += new System.EventHandler(this.BtnColision_Click);
            // 
            // BtnZombieWitch
            // 
            this.BtnZombieWitch.Location = new System.Drawing.Point(6, 138);
            this.BtnZombieWitch.Name = "BtnZombieWitch";
            this.BtnZombieWitch.Size = new System.Drawing.Size(41, 38);
            this.BtnZombieWitch.TabIndex = 2;
            this.BtnZombieWitch.Text = "ZW";
            this.BtnZombieWitch.UseVisualStyleBackColor = true;
            this.BtnZombieWitch.Click += new System.EventHandler(this.BtnZombieWitch_Click);
            // 
            // DlgPractica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 407);
            this.Controls.Add(this.PbxFondo);
            this.Controls.Add(this.PnlSuperior);
            this.Controls.Add(this.PnlLateral);
            this.Name = "DlgPractica2";
            this.Text = "DlgPractica2";
            this.PnlLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondo)).EndInit();
            this.PnlSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnZombie;
        private Panel PnlLateral;
        private PictureBox PbxFondo;
        private Panel PnlSuperior;
        private Button BtnZombieRomero;
        private Button BtnColision;
        private Button BtnZombieWitch;
    }
}