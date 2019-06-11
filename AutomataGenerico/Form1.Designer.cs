namespace AutomataGenerico
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvTransicion = new System.Windows.Forms.DataGridView();
            this.Estados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fdc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarEstados = new System.Windows.Forms.Button();
            this.txtNumEstados = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.txtCapturaCad = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransicion
            // 
            this.dgvTransicion.AllowUserToAddRows = false;
            this.dgvTransicion.AllowUserToDeleteRows = false;
            this.dgvTransicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estados,
            this.A,
            this.B,
            this.fdc});
            this.dgvTransicion.Location = new System.Drawing.Point(19, 103);
            this.dgvTransicion.Name = "dgvTransicion";
            this.dgvTransicion.Size = new System.Drawing.Size(445, 24);
            this.dgvTransicion.TabIndex = 0;
            // 
            // Estados
            // 
            this.Estados.HeaderText = "Estados";
            this.Estados.Name = "Estados";
            this.Estados.ReadOnly = true;
            this.Estados.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // B
            // 
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fdc
            // 
            this.fdc.HeaderText = "Fin de cadena";
            this.fdc.Name = "fdc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Cuantos estados son?";
            // 
            // btnGenerarEstados
            // 
            this.btnGenerarEstados.Location = new System.Drawing.Point(17, 69);
            this.btnGenerarEstados.Name = "btnGenerarEstados";
            this.btnGenerarEstados.Size = new System.Drawing.Size(112, 28);
            this.btnGenerarEstados.TabIndex = 2;
            this.btnGenerarEstados.Text = "Generar";
            this.btnGenerarEstados.UseVisualStyleBackColor = true;
            this.btnGenerarEstados.Click += new System.EventHandler(this.btnGenerarEstados_Click);
            // 
            // txtNumEstados
            // 
            this.txtNumEstados.Location = new System.Drawing.Point(19, 34);
            this.txtNumEstados.Name = "txtNumEstados";
            this.txtNumEstados.Size = new System.Drawing.Size(112, 20);
            this.txtNumEstados.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.GhostWhite;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(375, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "0=\"Error\"     1=\"Aceptar\"";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(209, 34);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(88, 28);
            this.btnComprobar.TabIndex = 5;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Visible = false;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // txtCapturaCad
            // 
            this.txtCapturaCad.Location = new System.Drawing.Point(209, 6);
            this.txtCapturaCad.Name = "txtCapturaCad";
            this.txtCapturaCad.Size = new System.Drawing.Size(236, 20);
            this.txtCapturaCad.TabIndex = 6;
            this.txtCapturaCad.Visible = false;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRes.Location = new System.Drawing.Point(224, 77);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(55, 13);
            this.lblRes.TabIndex = 7;
            this.lblRes.Text = "Resultado";
            this.lblRes.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(145, 69);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(56, 28);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::AutomataGenerico.Properties.Resources.if_information_309920;
            this.pictureBox1.Location = new System.Drawing.Point(451, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::AutomataGenerico.Properties.Resources.Vista_da_Serra_do_Mar_Ubatuba_170717;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 143);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtCapturaCad);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumEstados);
            this.Controls.Add(this.btnGenerarEstados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTransicion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarEstados;
        private System.Windows.Forms.TextBox txtNumEstados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estados;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewTextBoxColumn fdc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.TextBox txtCapturaCad;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

