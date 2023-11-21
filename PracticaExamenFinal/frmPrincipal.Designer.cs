namespace PracticaExamenFinal
{
    partial class frmPrincipal
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
            panel1 = new Panel();
            btnMin = new PictureBox();
            btnMax = new PictureBox();
            btnSalir = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnBeisbolistas = new Button();
            pnlContenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1747, 124);
            panel1.TabIndex = 0;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.Cursor = Cursors.Hand;
            btnMin.Image = Properties.Resources.minibuena;
            btnMin.Location = new Point(1487, 38);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(50, 50);
            btnMin.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMin.TabIndex = 3;
            btnMin.TabStop = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.Cursor = Cursors.Hand;
            btnMax.Image = Properties.Resources.maxbuena;
            btnMax.Location = new Point(1577, 38);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(50, 50);
            btnMax.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMax.TabIndex = 2;
            btnMax.TabStop = false;
            btnMax.Click += btnMax_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Image = Properties.Resources.cerrarbueno;
            btnSalir.Location = new Point(1667, 38);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(50, 50);
            btnSalir.SizeMode = PictureBoxSizeMode.StretchImage;
            btnSalir.TabIndex = 1;
            btnSalir.TabStop = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Location = new Point(3, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 200);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(btnBeisbolistas);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 800);
            panel3.TabIndex = 1;
            // 
            // btnBeisbolistas
            // 
            btnBeisbolistas.Cursor = Cursors.Hand;
            btnBeisbolistas.FlatAppearance.BorderSize = 0;
            btnBeisbolistas.FlatStyle = FlatStyle.Flat;
            btnBeisbolistas.ForeColor = Color.White;
            btnBeisbolistas.ImageAlign = ContentAlignment.MiddleLeft;
            btnBeisbolistas.Location = new Point(39, 169);
            btnBeisbolistas.Name = "btnBeisbolistas";
            btnBeisbolistas.Size = new Size(214, 46);
            btnBeisbolistas.TabIndex = 0;
            btnBeisbolistas.Text = "Beisbolistas";
            btnBeisbolistas.TextAlign = ContentAlignment.MiddleLeft;
            btnBeisbolistas.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnBeisbolistas.UseVisualStyleBackColor = true;
            btnBeisbolistas.Click += btnBeisbolistas_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.FromArgb(255, 192, 192);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(281, 124);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1466, 800);
            pnlContenedor.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1747, 924);
            Controls.Add(pnlContenedor);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            Opacity = 0.95D;
            Text = "frmPrincipal";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnSalir).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox btnMin;
        private PictureBox btnMax;
        private PictureBox btnSalir;
        private Panel pnlContenedor;
        private Button btnBeisbolistas;
    }
}