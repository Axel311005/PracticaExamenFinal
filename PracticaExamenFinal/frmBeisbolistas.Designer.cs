namespace PracticaExamenFinal
{
    partial class frmBeisbolistas
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAgregar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAB = new TextBox();
            txtH = new TextBox();
            txtLiga = new TextBox();
            txtPais = new TextBox();
            txtNombre = new TextBox();
            tabPage2 = new TabPage();
            cboBusqueda = new ComboBox();
            dgvDatos = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 54);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1371, 724);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtAB);
            tabPage1.Controls.Add(txtH);
            tabPage1.Controls.Add(txtLiga);
            tabPage1.Controls.Add(txtPais);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1355, 670);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Agregar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(838, 294);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 46);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 331);
            label5.Name = "label5";
            label5.Size = new Size(57, 32);
            label5.TabIndex = 10;
            label5.Text = "Liga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(540, 207);
            label4.Name = "label4";
            label4.Size = new Size(43, 32);
            label4.TabIndex = 9;
            label4.Text = "AB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 207);
            label3.Name = "label3";
            label3.Size = new Size(54, 32);
            label3.TabIndex = 8;
            label3.Text = "Pais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(540, 61);
            label2.Name = "label2";
            label2.Size = new Size(31, 32);
            label2.TabIndex = 7;
            label2.Text = "H";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 61);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // txtAB
            // 
            txtAB.Location = new Point(473, 251);
            txtAB.Name = "txtAB";
            txtAB.Size = new Size(200, 39);
            txtAB.TabIndex = 4;
            txtAB.KeyPress += txtAB_KeyPress;
            // 
            // txtH
            // 
            txtH.Location = new Point(473, 116);
            txtH.Name = "txtH";
            txtH.Size = new Size(200, 39);
            txtH.TabIndex = 3;
            txtH.KeyPress += txtH_KeyPress;
            // 
            // txtLiga
            // 
            txtLiga.Location = new Point(57, 378);
            txtLiga.Name = "txtLiga";
            txtLiga.Size = new Size(200, 39);
            txtLiga.TabIndex = 2;
            txtLiga.KeyPress += txtLiga_KeyPress;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(57, 251);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(200, 39);
            txtPais.TabIndex = 1;
            txtPais.KeyPress += txtPais_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cboBusqueda);
            tabPage2.Controls.Add(dgvDatos);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1355, 670);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Buscar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cboBusqueda
            // 
            cboBusqueda.FormattingEnabled = true;
            cboBusqueda.Location = new Point(224, 101);
            cboBusqueda.Name = "cboBusqueda";
            cboBusqueda.Size = new Size(242, 40);
            cboBusqueda.TabIndex = 1;
            cboBusqueda.SelectedIndexChanged += cboBusqueda_SelectedIndexChanged;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(33, 279);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 82;
            dgvDatos.RowTemplate.Height = 41;
            dgvDatos.Size = new Size(1299, 300);
            dgvDatos.TabIndex = 0;
            // 
            // frmBeisbolistas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 790);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBeisbolistas";
            Text = "frmBeisbolistas";
            Load += frmBeisbolistas_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAB;
        private TextBox txtH;
        private TextBox txtLiga;
        private TextBox txtPais;
        private TextBox txtNombre;
        private DataGridView dgvDatos;
        private Button btnAgregar;
        private ComboBox cboBusqueda;
    }
}