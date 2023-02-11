namespace POO23A_MA
{
    partial class DlgConfigurar
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.CbxEscogerPractica = new System.Windows.Forms.ComboBox();
            this.LblTexto = new System.Windows.Forms.Label();
            this.PnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFondo
            // 
            this.PnlFondo.BackgroundImage = global::POO23A_MA.Properties.Resources.Mesa_de_trabajo_1_100a;
            this.PnlFondo.Controls.Add(this.BtnGuardar);
            this.PnlFondo.Controls.Add(this.TbxDescripcion);
            this.PnlFondo.Controls.Add(this.CbxEscogerPractica);
            this.PnlFondo.Controls.Add(this.LblTexto);
            this.PnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlFondo.Location = new System.Drawing.Point(0, 0);
            this.PnlFondo.Name = "PnlFondo";
            this.PnlFondo.Size = new System.Drawing.Size(306, 432);
            this.PnlFondo.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(219, 397);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Location = new System.Drawing.Point(15, 87);
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(279, 23);
            this.TbxDescripcion.TabIndex = 2;
            this.TbxDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxDescripcion_KeyDown);
            // 
            // CbxEscogerPractica
            // 
            this.CbxEscogerPractica.FormattingEnabled = true;
            this.CbxEscogerPractica.Items.AddRange(new object[] {
            "Práctica 1",
            "Práctica 2",
            "Práctica 3",
            "Práctica 4",
            "Práctica 5",
            "Práctica 6",
            "Práctica 7",
            "Práctica 8",
            "Práctica 9",
            "Práctica 10"});
            this.CbxEscogerPractica.Location = new System.Drawing.Point(15, 51);
            this.CbxEscogerPractica.Name = "CbxEscogerPractica";
            this.CbxEscogerPractica.Size = new System.Drawing.Size(121, 23);
            this.CbxEscogerPractica.TabIndex = 1;
            this.CbxEscogerPractica.Text = "Práctica 1";
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.BackColor = System.Drawing.Color.Transparent;
            this.LblTexto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTexto.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTexto.Location = new System.Drawing.Point(12, 25);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(128, 15);
            this.LblTexto.TabIndex = 0;
            this.LblTexto.Text = "Modificar Descripción";
            // 
            // DlgConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 432);
            this.Controls.Add(this.PnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DlgConfigurar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DlgConfigurar";
            this.PnlFondo.ResumeLayout(false);
            this.PnlFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlFondo;
        private ComboBox CbxEscogerPractica;
        private Label LblTexto;
        private TextBox TbxDescripcion;
        private Button BtnGuardar;
    }
}