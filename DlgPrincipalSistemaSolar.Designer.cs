namespace POO23A_MA.Menus
{
    partial class DlgPrincipalSistemaSolar
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
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.BtnSeleccionarMenu = new System.Windows.Forms.Button();
            this.PnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackgroundImage = global::POO23A_MA.Properties.Resources.FondoMenuSistemaSolar;
            this.PnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlFondo.Controls.Add(this.BtnSeleccionarMenu);
            this.PnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFondo.Location = new System.Drawing.Point(0, 0);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(800, 450);
            this.PnlFondo.TabIndex = 0;
            // 
            // BtnSeleccionarMenu
            // 
            this.BtnSeleccionarMenu.BackColor = System.Drawing.Color.Transparent;
            this.BtnSeleccionarMenu.BackgroundImage = global::POO23A_MA.Properties.Resources.IconoSeleccionMenus;
            this.BtnSeleccionarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSeleccionarMenu.FlatAppearance.BorderSize = 0;
            this.BtnSeleccionarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionarMenu.Location = new System.Drawing.Point(3, 3);
            this.BtnSeleccionarMenu.Name = "BtnSeleccionarMenu";
            this.BtnSeleccionarMenu.Size = new System.Drawing.Size(25, 25);
            this.BtnSeleccionarMenu.TabIndex = 16;
            this.BtnSeleccionarMenu.UseVisualStyleBackColor = false;
            this.BtnSeleccionarMenu.Click += new System.EventHandler(this.BtnSeleccionarMenu_Click);
            // 
            // DlgPrincipalSistemaSolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlFondo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DlgPrincipalSistemaSolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgPrincipalSistemaSolar";
            this.PnlFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlFondo;
        private Button BtnSeleccionarMenu;
    }
}