namespace POO23A_MA
{
    partial class DlgBienvenida
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.LblNombreMenu = new System.Windows.Forms.Label();
            this.LblEjecutar = new System.Windows.Forms.Label();
            this.PbxMenuSistemaSolar = new System.Windows.Forms.PictureBox();
            this.PbxMenuQuimica = new System.Windows.Forms.PictureBox();
            this.PbxMenuCalendario = new System.Windows.Forms.PictureBox();
            this.PnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenuSistemaSolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenuQuimica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenuCalendario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Black;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCerrar.ForeColor = System.Drawing.Color.Red;
            this.BtnCerrar.Location = new System.Drawing.Point(364, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(37, 38);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.Text = "X";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackgroundImage = global::POO23A_MA.Properties.Resources.FondoBienvenida;
            this.PnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlFondo.Controls.Add(this.LblNombreMenu);
            this.PnlFondo.Controls.Add(this.LblEjecutar);
            this.PnlFondo.Controls.Add(this.PbxMenuSistemaSolar);
            this.PnlFondo.Controls.Add(this.PbxMenuQuimica);
            this.PnlFondo.Controls.Add(this.PbxMenuCalendario);
            this.PnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFondo.Location = new System.Drawing.Point(0, 0);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(403, 259);
            this.PnlFondo.TabIndex = 1;
            // 
            // LblNombreMenu
            // 
            this.LblNombreMenu.BackColor = System.Drawing.Color.Transparent;
            this.LblNombreMenu.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblNombreMenu.ForeColor = System.Drawing.Color.White;
            this.LblNombreMenu.Location = new System.Drawing.Point(105, 71);
            this.LblNombreMenu.Name = "LblNombreMenu";
            this.LblNombreMenu.Size = new System.Drawing.Size(194, 23);
            this.LblNombreMenu.TabIndex = 4;
            this.LblNombreMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblEjecutar
            // 
            this.LblEjecutar.AutoSize = true;
            this.LblEjecutar.BackColor = System.Drawing.Color.Transparent;
            this.LblEjecutar.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblEjecutar.ForeColor = System.Drawing.Color.White;
            this.LblEjecutar.Location = new System.Drawing.Point(106, 40);
            this.LblEjecutar.Name = "LblEjecutar";
            this.LblEjecutar.Size = new System.Drawing.Size(190, 23);
            this.LblEjecutar.TabIndex = 3;
            this.LblEjecutar.Text = "Seleccione su menú";
            // 
            // PbxMenuSistemaSolar
            // 
            this.PbxMenuSistemaSolar.BackColor = System.Drawing.Color.Transparent;
            this.PbxMenuSistemaSolar.Image = global::POO23A_MA.Properties.Resources.IconoSistemaSolar;
            this.PbxMenuSistemaSolar.Location = new System.Drawing.Point(278, 107);
            this.PbxMenuSistemaSolar.Name = "PbxMenuSistemaSolar";
            this.PbxMenuSistemaSolar.Size = new System.Drawing.Size(75, 75);
            this.PbxMenuSistemaSolar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMenuSistemaSolar.TabIndex = 2;
            this.PbxMenuSistemaSolar.TabStop = false;
            this.PbxMenuSistemaSolar.Click += new System.EventHandler(this.PbxMenuSistemaSolar_Click);
            this.PbxMenuSistemaSolar.MouseEnter += new System.EventHandler(this.PbxMenu3_MouseEnter);
            this.PbxMenuSistemaSolar.MouseLeave += new System.EventHandler(this.PbxMenu3_MouseLeave);
            // 
            // PbxMenuQuimica
            // 
            this.PbxMenuQuimica.BackColor = System.Drawing.Color.Transparent;
            this.PbxMenuQuimica.Image = global::POO23A_MA.Properties.Resources.IconoQuimica2;
            this.PbxMenuQuimica.Location = new System.Drawing.Point(165, 107);
            this.PbxMenuQuimica.Name = "PbxMenuQuimica";
            this.PbxMenuQuimica.Size = new System.Drawing.Size(75, 75);
            this.PbxMenuQuimica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMenuQuimica.TabIndex = 1;
            this.PbxMenuQuimica.TabStop = false;
            this.PbxMenuQuimica.Click += new System.EventHandler(this.PbxMenuQuimica_Click);
            this.PbxMenuQuimica.MouseEnter += new System.EventHandler(this.PbxMenuQuimica_MouseEnter);
            this.PbxMenuQuimica.MouseLeave += new System.EventHandler(this.PbxMenuQuimica_MouseLeave);
            // 
            // PbxMenuCalendario
            // 
            this.PbxMenuCalendario.BackColor = System.Drawing.Color.Transparent;
            this.PbxMenuCalendario.Image = global::POO23A_MA.Properties.Resources.IconoCalendario;
            this.PbxMenuCalendario.Location = new System.Drawing.Point(46, 107);
            this.PbxMenuCalendario.Name = "PbxMenuCalendario";
            this.PbxMenuCalendario.Size = new System.Drawing.Size(75, 75);
            this.PbxMenuCalendario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxMenuCalendario.TabIndex = 0;
            this.PbxMenuCalendario.TabStop = false;
            this.PbxMenuCalendario.Click += new System.EventHandler(this.PbxMenuCalendario_Click);
            this.PbxMenuCalendario.MouseEnter += new System.EventHandler(this.PbxMenuCalendario_MouseEnter);
            this.PbxMenuCalendario.MouseLeave += new System.EventHandler(this.PbxMenuCalendario_MouseLeave);
            // 
            // DlgBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 259);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.PnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DlgBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PnlFondo.ResumeLayout(false);
            this.PnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenuSistemaSolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenuQuimica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxMenuCalendario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnCerrar;
        private Panel PnlFondo;
        private PictureBox PbxMenuCalendario;
        private PictureBox PbxMenuSistemaSolar;
        private PictureBox PbxMenuQuimica;
        private Label LblEjecutar;
        private Label LblNombreMenu;
    }
}