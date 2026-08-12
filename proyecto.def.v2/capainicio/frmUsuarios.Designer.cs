//namespace capainicio
//{
//    partial class frmUsuarios
//    {
//        /// <summary>
//        /// Variable del diseñador requerida.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Limpiar los recursos que se estén utilizando.
//        /// </summary>
//        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Código generado por el Diseñador de Windows Forms

//        /// <summary>
//        /// Método necesario para admitir el Diseñador. No se puede modificar
//        /// el contenido de este método con el editor de código.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.btnAgregar = new FontAwesome.Sharp.IconButton();
//            this.dataGridView1 = new System.Windows.Forms.DataGridView();
//            this.pnlRegistro = new System.Windows.Forms.Panel();
//            this.cboCamaras = new System.Windows.Forms.ComboBox();
//            this.picCamara = new System.Windows.Forms.PictureBox();
//            this.lblCarrera = new System.Windows.Forms.Label();
//            this.lblApellido = new System.Windows.Forms.Label();
//            this.lblNombre = new System.Windows.Forms.Label();
//            this.lblDNI = new System.Windows.Forms.Label();
//            this.lblEscaneo = new System.Windows.Forms.Label();
//            this.btnEscanearDNI = new FontAwesome.Sharp.IconButton();
//            this.btnGuardar = new FontAwesome.Sharp.IconButton();
//            this.cboCarrera = new System.Windows.Forms.ComboBox();
//            this.txtApellido = new System.Windows.Forms.TextBox();
//            this.txtNombre = new System.Windows.Forms.TextBox();
//            this.txtDNI = new System.Windows.Forms.TextBox();
//            this.textEscaneoDNI = new System.Windows.Forms.TextBox();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
//            this.pnlRegistro.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // btnAgregar
//            // 
//            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
//            this.btnAgregar.IconColor = System.Drawing.Color.Black;
//            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
//            this.btnAgregar.IconSize = 20;
//            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
//            this.btnAgregar.Name = "btnAgregar";
//            this.btnAgregar.Size = new System.Drawing.Size(150, 30);
//            this.btnAgregar.TabIndex = 0;
//            this.btnAgregar.Text = "Agregar Estudiante +";
//            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.btnAgregar.UseVisualStyleBackColor = true;
//            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
//            // 
//            // dataGridView1
//            // 
//            this.dataGridView1.AllowUserToAddRows = false;
//            this.dataGridView1.AllowUserToDeleteRows = false;
//            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
//            this.dataGridView1.Location = new System.Drawing.Point(0, 260);
//            this.dataGridView1.Name = "dataGridView1";
//            this.dataGridView1.ReadOnly = true;
//            this.dataGridView1.Size = new System.Drawing.Size(800, 190);
//            this.dataGridView1.TabIndex = 1;
//            // 
//            // pnlRegistro
//            // 
//            this.pnlRegistro.Controls.Add(this.cboCamaras);
//            this.pnlRegistro.Controls.Add(this.picCamara);
//            this.pnlRegistro.Controls.Add(this.lblCarrera);
//            this.pnlRegistro.Controls.Add(this.lblApellido);
//            this.pnlRegistro.Controls.Add(this.lblNombre);
//            this.pnlRegistro.Controls.Add(this.lblDNI);
//            this.pnlRegistro.Controls.Add(this.lblEscaneo);
//            this.pnlRegistro.Controls.Add(this.btnEscanearDNI);
//            this.pnlRegistro.Controls.Add(this.btnGuardar);
//            this.pnlRegistro.Controls.Add(this.cboCarrera);
//            this.pnlRegistro.Controls.Add(this.txtApellido);
//            this.pnlRegistro.Controls.Add(this.txtNombre);
//            this.pnlRegistro.Controls.Add(this.txtDNI);
//            this.pnlRegistro.Controls.Add(this.textEscaneoDNI);
//            this.pnlRegistro.Location = new System.Drawing.Point(175, 12);
//            this.pnlRegistro.Name = "pnlRegistro";
//            this.pnlRegistro.Size = new System.Drawing.Size(610, 240);
//            this.pnlRegistro.TabIndex = 2;
//            this.pnlRegistro.Visible = false;
//            // 
//            // cboCamaras
//            // 
//            this.cboCamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.cboCamaras.FormattingEnabled = true;
//            this.cboCamaras.Location = new System.Drawing.Point(360, 22);
//            this.cboCamaras.Name = "cboCamaras";
//            this.cboCamaras.Size = new System.Drawing.Size(230, 21);
//            this.cboCamaras.TabIndex = 13;
//            // 
//            // picCamara
//            // 
//            this.picCamara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
//            this.picCamara.Location = new System.Drawing.Point(360, 55);
//            this.picCamara.Name = "picCamara";
//            this.picCamara.Size = new System.Drawing.Size(230, 160);
//            this.picCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.picCamara.TabIndex = 12;
//            this.picCamara.TabStop = false;
//            // 
//            // lblCarrera
//            // 
//            this.lblCarrera.AutoSize = true;
//            this.lblCarrera.Location = new System.Drawing.Point(15, 157);
//            this.lblCarrera.Name = "lblCarrera";
//            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
//            this.lblCarrera.TabIndex = 11;
//            this.lblCarrera.Text = "Carrera:";
//            // 
//            // lblApellido
//            // 
//            this.lblApellido.AutoSize = true;
//            this.lblApellido.Location = new System.Drawing.Point(15, 124);
//            this.lblApellido.Name = "lblApellido";
//            this.lblApellido.Size = new System.Drawing.Size(47, 13);
//            this.lblApellido.TabIndex = 10;
//            this.lblApellido.Text = "Apellido:";
//            // 
//            // lblNombre
//            // 
//            this.lblNombre.AutoSize = true;
//            this.lblNombre.Location = new System.Drawing.Point(15, 91);
//            this.lblNombre.Name = "lblNombre";
//            this.lblNombre.Size = new System.Drawing.Size(47, 13);
//            this.lblNombre.TabIndex = 9;
//            this.lblNombre.Text = "Nombre:";
//            // 
//            // lblDNI
//            // 
//            this.lblDNI.AutoSize = true;
//            this.lblDNI.Location = new System.Drawing.Point(15, 58);
//            this.lblDNI.Name = "lblDNI";
//            this.lblDNI.Size = new System.Drawing.Size(29, 13);
//            this.lblDNI.TabIndex = 8;
//            this.lblDNI.Text = "DNI:";
//            // 
//            // lblEscaneo
//            // 
//            this.lblEscaneo.AutoSize = true;
//            this.lblEscaneo.Location = new System.Drawing.Point(15, 25);
//            this.lblEscaneo.Name = "lblEscaneo";
//            this.lblEscaneo.Size = new System.Drawing.Size(76, 13);
//            this.lblEscaneo.TabIndex = 7;
//            this.lblEscaneo.Text = "Lector Barcode:";
//            // 
//            // btnEscanearDNI
//            // 
//            this.btnEscanearDNI.IconChar = FontAwesome.Sharp.IconChar.Camera;
//            this.btnEscanearDNI.IconColor = System.Drawing.Color.Black;
//            this.btnEscanearDNI.IconFont = FontAwesome.Sharp.IconFont.Auto;
//            this.btnEscanearDNI.IconSize = 18;
//            this.btnEscanearDNI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btnEscanearDNI.Location = new System.Drawing.Point(220, 188);
//            this.btnEscanearDNI.Name = "btnEscanearDNI";
//            this.btnEscanearDNI.Size = new System.Drawing.Size(125, 30);
//            this.btnEscanearDNI.TabIndex = 6;
//            this.btnEscanearDNI.Text = "Iniciar Cámara";
//            this.btnEscanearDNI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.btnEscanearDNI.UseVisualStyleBackColor = true;
//            this.btnEscanearDNI.Click += new System.EventHandler(this.btnEscanearDNI_Click);
//            // 
//            // btnGuardar
//            // 
//            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
//            this.btnGuardar.IconColor = System.Drawing.Color.Black;
//            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
//            this.btnGuardar.IconSize = 18;
//            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btnGuardar.Location = new System.Drawing.Point(100, 188);
//            this.btnGuardar.Name = "btnGuardar";
//            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
//            this.btnGuardar.TabIndex = 5;
//            this.btnGuardar.Text = "Guardar";
//            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.btnGuardar.UseVisualStyleBackColor = true;
//            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
//            // 
//            // cboCarrera
//            // 
//            this.cboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.cboCarrera.FormattingEnabled = true;
//            this.cboCarrera.Location = new System.Drawing.Point(100, 154);
//            this.cboCarrera.Name = "cboCarrera";
//            this.cboCarrera.Size = new System.Drawing.Size(245, 21);
//            this.cboCarrera.TabIndex = 4;
//            // 
//            // txtApellido
//            // 
//            this.txtApellido.Location = new System.Drawing.Point(100, 121);
//            this.txtApellido.Name = "txtApellido";
//            this.txtApellido.Size = new System.Drawing.Size(245, 20);
//            this.txtApellido.TabIndex = 3;
//            // 
//            // txtNombre
//            // 
//            this.txtNombre.Location = new System.Drawing.Point(100, 88);
//            this.txtNombre.Name = "txtNombre";
//            this.txtNombre.Size = new System.Drawing.Size(245, 20);
//            this.txtNombre.TabIndex = 2;
//            // 
//            // txtDNI
//            // 
//            this.txtDNI.Location = new System.Drawing.Point(100, 55);
//            this.txtDNI.Name = "txtDNI";
//            this.txtDNI.Size = new System.Drawing.Size(245, 20);
//            this.txtDNI.TabIndex = 1;
//            // 
//            // textEscaneoDNI
//            // 
//            this.textEscaneoDNI.Location = new System.Drawing.Point(100, 22);
//            this.textEscaneoDNI.Name = "textEscaneoDNI";
//            this.textEscaneoDNI.Size = new System.Drawing.Size(245, 20);
//            this.textEscaneoDNI.TabIndex = 0;
//            this.textEscaneoDNI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEscaneoDNI_KeyDown);
//            // 
//            // frmUsuarios
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Controls.Add(this.pnlRegistro);
//            this.Controls.Add(this.dataGridView1);
//            this.Controls.Add(this.btnAgregar);
//            this.Name = "frmUsuarios";
//            this.Text = "Gestión de Estudiantes";
//            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuarios_FormClosing);
//            this.Load += new System.EventHandler(this.frmUsuarios_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
//            this.pnlRegistro.ResumeLayout(false);
//            this.pnlRegistro.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picCamara)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private FontAwesome.Sharp.IconButton btnAgregar;
//        private System.Windows.Forms.DataGridView dataGridView1;
//        private System.Windows.Forms.Panel pnlRegistro;
//        private System.Windows.Forms.TextBox txtApellido;
//        private System.Windows.Forms.TextBox txtNombre;
//        private System.Windows.Forms.TextBox txtDNI;
//        private System.Windows.Forms.TextBox textEscaneoDNI;
//        private FontAwesome.Sharp.IconButton btnGuardar;
//        private FontAwesome.Sharp.IconButton btnEscanearDNI;
//        private System.Windows.Forms.ComboBox cboCarrera;
//        private System.Windows.Forms.Label lblEscaneo;
//        private System.Windows.Forms.Label lblDNI;
//        private System.Windows.Forms.Label lblNombre;
//        private System.Windows.Forms.Label lblApellido;
//        private System.Windows.Forms.Label lblCarrera;
//        private System.Windows.Forms.ComboBox cboCamaras;
//        private System.Windows.Forms.PictureBox picCamara;
//    }
//}