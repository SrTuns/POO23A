namespace POO23A_MA
{
    partial class DlgPractica1
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
            this.PbxIconoPractica1 = new System.Windows.Forms.PictureBox();
            this.PnlFondo = new System.Windows.Forms.Panel();
            this.Btn100Calculadoras = new System.Windows.Forms.Button();
            this.BtnCalculadora = new System.Windows.Forms.Button();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblPractica1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbxIconoPractica1)).BeginInit();
            this.PnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PbxIconoPractica1
            // 
            this.PbxIconoPractica1.Image = global::POO23A_MA.Properties.Resources.ImagenP1;
            this.PbxIconoPractica1.Location = new System.Drawing.Point(12, 12);
            this.PbxIconoPractica1.Name = "PbxIconoPractica1";
            this.PbxIconoPractica1.Size = new System.Drawing.Size(101, 100);
            this.PbxIconoPractica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxIconoPractica1.TabIndex = 0;
            this.PbxIconoPractica1.TabStop = false;
            this.PbxIconoPractica1.Click += new System.EventHandler(this.PbxIconoPractica1_Click);
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackgroundImage = global::POO23A_MA.Properties.Resources.Mesa_de_trabajo_1_100a;
            this.PnlFondo.Controls.Add(this.Btn100Calculadoras);
            this.PnlFondo.Controls.Add(this.BtnCalculadora);
            this.PnlFondo.Controls.Add(this.LblDescripcion);
            this.PnlFondo.Controls.Add(this.LblPractica1);
            this.PnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFondo.Location = new System.Drawing.Point(0, 0);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(800, 450);
            this.PnlFondo.TabIndex = 1;
            // 
            // Btn100Calculadoras
            // 
            this.Btn100Calculadoras.Location = new System.Drawing.Point(20, 170);
            this.Btn100Calculadoras.Name = "Btn100Calculadoras";
            this.Btn100Calculadoras.Size = new System.Drawing.Size(141, 27);
            this.Btn100Calculadoras.TabIndex = 3;
            this.Btn100Calculadoras.Text = "Calculadora Básica I100";
            this.Btn100Calculadoras.UseVisualStyleBackColor = true;
            this.Btn100Calculadoras.Click += new System.EventHandler(this.Btn100Calculadoras_Click);
            // 
            // BtnCalculadora
            // 
            this.BtnCalculadora.Location = new System.Drawing.Point(20, 137);
            this.BtnCalculadora.Name = "BtnCalculadora";
            this.BtnCalculadora.Size = new System.Drawing.Size(141, 27);
            this.BtnCalculadora.TabIndex = 2;
            this.BtnCalculadora.Text = "Calculadora Básica 3V";
            this.BtnCalculadora.UseVisualStyleBackColor = true;
            this.BtnCalculadora.Click += new System.EventHandler(this.BtnCalculadora_Click);
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.LblDescripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.LblDescripcion.Location = new System.Drawing.Point(121, 74);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(227, 38);
            this.LblDescripcion.TabIndex = 1;
            // 
            // LblPractica1
            // 
            this.LblPractica1.BackColor = System.Drawing.Color.Transparent;
            this.LblPractica1.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPractica1.Location = new System.Drawing.Point(121, 16);
            this.LblPractica1.Name = "LblPractica1";
            this.LblPractica1.Size = new System.Drawing.Size(227, 58);
            this.LblPractica1.TabIndex = 0;
            this.LblPractica1.Text = "N° Práctica: 1\r\nFecha Inicio: 26-01-23\r\nSimbolo Práctica: I\r\nNombre: Inicio";
            // 
            // DlgPractica1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PbxIconoPractica1);
            this.Controls.Add(this.PnlFondo);
            this.Name = "DlgPractica1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica 1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxIconoPractica1)).EndInit();
            this.PnlFondo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PbxIconoPractica1;
        private Panel PnlFondo;
        private Label LblPractica1;
        private Label LblDescripcion;
        private Button BtnCalculadora;
        private Button Btn100Calculadoras;
    }
}