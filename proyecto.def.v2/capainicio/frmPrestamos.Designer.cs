namespace capainicio
{
    partial class frmPrestamos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxAlumno = new System.Windows.Forms.GroupBox();
            this.lblDniLabel = new System.Windows.Forms.Label();
            this.txtDniAlumno = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumno = new FontAwesome.Sharp.IconButton();
            this.lblNombreLabel = new System.Windows.Forms.Label();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.lblHistorialLabel = new System.Windows.Forms.Label();
            this.dgvHistorialAlumno = new System.Windows.Forms.DataGridView();
            this.id_prestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlOperaciones = new System.Windows.Forms.TabControl();
            this.tabPrestamo = new System.Windows.Forms.TabPage();
            this.lblSeleccionTipo = new System.Windows.Forms.Label();
            this.chkComputadora = new System.Windows.Forms.CheckBox();
            this.chkLibro = new System.Windows.Forms.CheckBox();
            this.lblComputadora = new System.Windows.Forms.Label();
            this.cboComputadoras = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cboLibros = new System.Windows.Forms.ComboBox();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lblRecepcionistaActivo = new System.Windows.Forms.Label();
            this.lblConfirmarClave = new System.Windows.Forms.Label();
            this.txtClaveConfirmacion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.tabDevolucion = new System.Windows.Forms.TabPage();
            this.lblInfoDevolucion = new System.Windows.Forms.Label();
            this.lblEstadoFisico = new System.Windows.Forms.Label();
            this.cboEstadoFisico = new System.Windows.Forms.ComboBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnRegistrarDevolucion = new FontAwesome.Sharp.IconButton();
            this.imgListTabs = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAlumno)).BeginInit();
            this.tabControlOperaciones.SuspendLayout();
            this.tabPrestamo.SuspendLayout();
            this.tabDevolucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlumno
            // 
            this.groupBoxAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAlumno.Controls.Add(this.lblDniLabel);
            this.groupBoxAlumno.Controls.Add(this.txtDniAlumno);
            this.groupBoxAlumno.Controls.Add(this.btnBuscarAlumno);
            this.groupBoxAlumno.Controls.Add(this.lblNombreLabel);
            this.groupBoxAlumno.Controls.Add(this.lblNombreAlumno);
            this.groupBoxAlumno.Controls.Add(this.lblHistorialLabel);
            this.groupBoxAlumno.Controls.Add(this.dgvHistorialAlumno);
            this.groupBoxAlumno.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAlumno.Name = "groupBoxAlumno";
            this.groupBoxAlumno.Size = new System.Drawing.Size(550, 430);
            this.groupBoxAlumno.TabIndex = 0;
            this.groupBoxAlumno.TabStop = false;
            this.groupBoxAlumno.Text = "Búsqueda del Alumno";
            // 
            // lblDniLabel
            // 
            this.lblDniLabel.AutoSize = true;
            this.lblDniLabel.Location = new System.Drawing.Point(15, 28);
            this.lblDniLabel.Name = "lblDniLabel";
            this.lblDniLabel.Size = new System.Drawing.Size(71, 13);
            this.lblDniLabel.TabIndex = 0;
            this.lblDniLabel.Text = "DNI / Carnet:";
            // 
            // txtDniAlumno
            // 
            this.txtDniAlumno.Location = new System.Drawing.Point(18, 47);
            this.txtDniAlumno.Name = "txtDniAlumno";
            this.txtDniAlumno.Size = new System.Drawing.Size(180, 20);
            this.txtDniAlumno.TabIndex = 1;
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarAlumno.FlatAppearance.BorderSize = 0;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAlumno.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarAlumno.IconColor = System.Drawing.Color.White;
            this.btnBuscarAlumno.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarAlumno.IconSize = 18;
            this.btnBuscarAlumno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(210, 44);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(150, 25);
            this.btnBuscarAlumno.TabIndex = 2;
            this.btnBuscarAlumno.Text = "Buscar Alumno";
            this.btnBuscarAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarAlumno.UseVisualStyleBackColor = false;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // lblNombreLabel
            // 
            this.lblNombreLabel.AutoSize = true;
            this.lblNombreLabel.Location = new System.Drawing.Point(15, 82);
            this.lblNombreLabel.Name = "lblNombreLabel";
            this.lblNombreLabel.Size = new System.Drawing.Size(113, 13);
            this.lblNombreLabel.TabIndex = 3;
            this.lblNombreLabel.Text = "Alumno Seleccionado:";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombreAlumno.Location = new System.Drawing.Point(150, 82);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(23, 13);
            this.lblNombreAlumno.TabIndex = 4;
            this.lblNombreAlumno.Text = "---";
            // 
            // lblHistorialLabel
            // 
            this.lblHistorialLabel.AutoSize = true;
            this.lblHistorialLabel.Location = new System.Drawing.Point(15, 118);
            this.lblHistorialLabel.Name = "lblHistorialLabel";
            this.lblHistorialLabel.Size = new System.Drawing.Size(114, 13);
            this.lblHistorialLabel.TabIndex = 5;
            this.lblHistorialLabel.Text = "Historial de Préstamos:";
            // 
            // dgvHistorialAlumno
            // 
            this.dgvHistorialAlumno.AllowUserToAddRows = false;
            this.dgvHistorialAlumno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistorialAlumno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorialAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prestamo,
            this.Recurso,
            this.FechaPrestamo,
            this.FechaDevolucion,
            this.Estado});
            this.dgvHistorialAlumno.Location = new System.Drawing.Point(18, 137);
            this.dgvHistorialAlumno.MultiSelect = false;
            this.dgvHistorialAlumno.Name = "dgvHistorialAlumno";
            this.dgvHistorialAlumno.ReadOnly = true;
            this.dgvHistorialAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialAlumno.Size = new System.Drawing.Size(514, 275);
            this.dgvHistorialAlumno.TabIndex = 6;
            // 
            // id_prestamo
            // 
            this.id_prestamo.HeaderText = "ID";
            this.id_prestamo.Name = "id_prestamo";
            this.id_prestamo.ReadOnly = true;
            this.id_prestamo.Visible = false;
            // 
            // Recurso
            // 
            this.Recurso.HeaderText = "Recurso / Código";
            this.Recurso.Name = "Recurso";
            this.Recurso.ReadOnly = true;
            // 
            // FechaPrestamo
            // 
            this.FechaPrestamo.HeaderText = "Fecha Préstamo";
            this.FechaPrestamo.Name = "FechaPrestamo";
            this.FechaPrestamo.ReadOnly = true;
            // 
            // FechaDevolucion
            // 
            this.FechaDevolucion.HeaderText = "Fecha Devolución";
            this.FechaDevolucion.Name = "FechaDevolucion";
            this.FechaDevolucion.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // tabControlOperaciones
            // 
            this.tabControlOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlOperaciones.Controls.Add(this.tabPrestamo);
            this.tabControlOperaciones.Controls.Add(this.tabDevolucion);
            this.tabControlOperaciones.ImageList = this.imgListTabs;
            this.tabControlOperaciones.Location = new System.Drawing.Point(575, 12);
            this.tabControlOperaciones.Name = "tabControlOperaciones";
            this.tabControlOperaciones.SelectedIndex = 0;
            this.tabControlOperaciones.Size = new System.Drawing.Size(370, 430);
            this.tabControlOperaciones.TabIndex = 1;
            // 
            // tabPrestamo
            // 
            this.tabPrestamo.Controls.Add(this.lblSeleccionTipo);
            this.tabPrestamo.Controls.Add(this.chkComputadora);
            this.tabPrestamo.Controls.Add(this.chkLibro);
            this.tabPrestamo.Controls.Add(this.lblComputadora);
            this.tabPrestamo.Controls.Add(this.cboComputadoras);
            this.tabPrestamo.Controls.Add(this.lblLibro);
            this.tabPrestamo.Controls.Add(this.cboLibros);
            this.tabPrestamo.Controls.Add(this.lblFechaDev);
            this.tabPrestamo.Controls.Add(this.dtpFechaLimite);
            this.tabPrestamo.Controls.Add(this.lblRecepcionistaActivo);
            this.tabPrestamo.Controls.Add(this.lblConfirmarClave);
            this.tabPrestamo.Controls.Add(this.txtClaveConfirmacion);
            this.tabPrestamo.Controls.Add(this.btnRegistrar);
            this.tabPrestamo.ImageIndex = 0;
            this.tabPrestamo.Location = new System.Drawing.Point(4, 23);
            this.tabPrestamo.Name = "tabPrestamo";
            this.tabPrestamo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrestamo.Size = new System.Drawing.Size(362, 403);
            this.tabPrestamo.TabIndex = 0;
            this.tabPrestamo.Text = " Registrar Préstamo";
            this.tabPrestamo.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionTipo
            // 
            this.lblSeleccionTipo.AutoSize = true;
            this.lblSeleccionTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSeleccionTipo.Location = new System.Drawing.Point(20, 10);
            this.lblSeleccionTipo.Name = "lblSeleccionTipo";
            this.lblSeleccionTipo.Size = new System.Drawing.Size(155, 13);
            this.lblSeleccionTipo.TabIndex = 0;
            this.lblSeleccionTipo.Text = "Tipo de Recurso a Prestar:";
            // 
            // chkComputadora
            // 
            this.chkComputadora.AutoSize = true;
            this.chkComputadora.Checked = true;
            this.chkComputadora.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkComputadora.Location = new System.Drawing.Point(23, 28);
            this.chkComputadora.Name = "chkComputadora";
            this.chkComputadora.Size = new System.Drawing.Size(89, 17);
            this.chkComputadora.TabIndex = 1;
            this.chkComputadora.Text = "Computadora";
            this.chkComputadora.UseVisualStyleBackColor = true;
            this.chkComputadora.CheckedChanged += new System.EventHandler(this.chkTipoRecurso_CheckedChanged);
            // 
            // chkLibro
            // 
            this.chkLibro.AutoSize = true;
            this.chkLibro.Location = new System.Drawing.Point(130, 28);
            this.chkLibro.Name = "chkLibro";
            this.chkLibro.Size = new System.Drawing.Size(49, 17);
            this.chkLibro.TabIndex = 2;
            this.chkLibro.Text = "Libro";
            this.chkLibro.UseVisualStyleBackColor = true;
            this.chkLibro.CheckedChanged += new System.EventHandler(this.chkTipoRecurso_CheckedChanged);
            // 
            // lblComputadora
            // 
            this.lblComputadora.AutoSize = true;
            this.lblComputadora.Location = new System.Drawing.Point(20, 52);
            this.lblComputadora.Name = "lblComputadora";
            this.lblComputadora.Size = new System.Drawing.Size(127, 13);
            this.lblComputadora.TabIndex = 3;
            this.lblComputadora.Text = "Computadora Disponible:";
            // 
            // cboComputadoras
            // 
            this.cboComputadoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComputadoras.FormattingEnabled = true;
            this.cboComputadoras.Location = new System.Drawing.Point(23, 68);
            this.cboComputadoras.Name = "cboComputadoras";
            this.cboComputadoras.Size = new System.Drawing.Size(315, 21);
            this.cboComputadoras.TabIndex = 4;
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(20, 97);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(87, 13);
            this.lblLibro.TabIndex = 5;
            this.lblLibro.Text = "Libro Disponible:";
            // 
            // cboLibros
            // 
            this.cboLibros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLibros.Enabled = false;
            this.cboLibros.FormattingEnabled = true;
            this.cboLibros.Location = new System.Drawing.Point(23, 113);
            this.cboLibros.Name = "cboLibros";
            this.cboLibros.Size = new System.Drawing.Size(315, 21);
            this.cboLibros.TabIndex = 6;
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.Location = new System.Drawing.Point(20, 142);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(158, 13);
            this.lblFechaDev.TabIndex = 7;
            this.lblFechaDev.Text = "Fecha de Devolución Estimada:";
            // 
            // dtpFechaLimite
            // 
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimite.Location = new System.Drawing.Point(23, 158);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(315, 20);
            this.dtpFechaLimite.TabIndex = 8;
            // 
            // lblRecepcionistaActivo
            // 
            this.lblRecepcionistaActivo.AutoSize = true;
            this.lblRecepcionistaActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRecepcionistaActivo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRecepcionistaActivo.Location = new System.Drawing.Point(20, 190);
            this.lblRecepcionistaActivo.Name = "lblRecepcionistaActivo";
            this.lblRecepcionistaActivo.Size = new System.Drawing.Size(161, 13);
            this.lblRecepcionistaActivo.TabIndex = 9;
            this.lblRecepcionistaActivo.Text = "Operador: [Cargando...]";
            // 
            // lblConfirmarClave
            // 
            this.lblConfirmarClave.AutoSize = true;
            this.lblConfirmarClave.Location = new System.Drawing.Point(20, 212);
            this.lblConfirmarClave.Name = "lblConfirmarClave";
            this.lblConfirmarClave.Size = new System.Drawing.Size(202, 13);
            this.lblConfirmarClave.TabIndex = 10;
            this.lblConfirmarClave.Text = "Confirmar Contraseña del Recepcionista:";
            // 
            // txtClaveConfirmacion
            // 
            this.txtClaveConfirmacion.Location = new System.Drawing.Point(23, 228);
            this.txtClaveConfirmacion.Name = "txtClaveConfirmacion";
            this.txtClaveConfirmacion.PasswordChar = '*';
            this.txtClaveConfirmacion.Size = new System.Drawing.Size(315, 20);
            this.txtClaveConfirmacion.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnRegistrar.IconColor = System.Drawing.Color.White;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.IconSize = 24;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.Location = new System.Drawing.Point(23, 260);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(315, 40);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Confirmar Préstamo";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tabDevolucion
            // 
            this.tabDevolucion.Controls.Add(this.lblInfoDevolucion);
            this.tabDevolucion.Controls.Add(this.lblEstadoFisico);
            this.tabDevolucion.Controls.Add(this.cboEstadoFisico);
            this.tabDevolucion.Controls.Add(this.lblObservaciones);
            this.tabDevolucion.Controls.Add(this.txtObservaciones);
            this.tabDevolucion.Controls.Add(this.btnRegistrarDevolucion);
            this.tabDevolucion.ImageIndex = 1;
            this.tabDevolucion.Location = new System.Drawing.Point(4, 23);
            this.tabDevolucion.Name = "tabDevolucion";
            this.tabDevolucion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevolucion.Size = new System.Drawing.Size(362, 403);
            this.tabDevolucion.TabIndex = 1;
            this.tabDevolucion.Text = " Registrar Devolución";
            this.tabDevolucion.UseVisualStyleBackColor = true;
            // 
            // lblInfoDevolucion
            // 
            this.lblInfoDevolucion.ForeColor = System.Drawing.Color.DimGray;
            this.lblInfoDevolucion.Location = new System.Drawing.Point(20, 20);
            this.lblInfoDevolucion.Name = "lblInfoDevolucion";
            this.lblInfoDevolucion.Size = new System.Drawing.Size(315, 30);
            this.lblInfoDevolucion.TabIndex = 0;
            this.lblInfoDevolucion.Text = "Seleccione un préstamo \'activo\' en la tabla para procesar su devolución.";
            // 
            // lblEstadoFisico
            // 
            this.lblEstadoFisico.AutoSize = true;
            this.lblEstadoFisico.Location = new System.Drawing.Point(20, 65);
            this.lblEstadoFisico.Name = "lblEstadoFisico";
            this.lblEstadoFisico.Size = new System.Drawing.Size(129, 13);
            this.lblEstadoFisico.TabIndex = 1;
            this.lblEstadoFisico.Text = "Estado Físico al Entregar:";
            // 
            // cboEstadoFisico
            // 
            this.cboEstadoFisico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoFisico.FormattingEnabled = true;
            this.cboEstadoFisico.Location = new System.Drawing.Point(23, 85);
            this.cboEstadoFisico.Name = "cboEstadoFisico";
            this.cboEstadoFisico.Size = new System.Drawing.Size(315, 21);
            this.cboEstadoFisico.TabIndex = 2;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 130);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(130, 13);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones / Detalles:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(23, 150);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(315, 80);
            this.txtObservaciones.TabIndex = 4;
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.BackColor = System.Drawing.Color.Firebrick;
            this.btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDevolucion.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarDevolucion.IconChar = FontAwesome.Sharp.IconChar.RotateLeft;
            this.btnRegistrarDevolucion.IconColor = System.Drawing.Color.White;
            this.btnRegistrarDevolucion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrarDevolucion.IconSize = 24;
            this.btnRegistrarDevolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(23, 260);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(315, 45);
            this.btnRegistrarDevolucion.TabIndex = 5;
            this.btnRegistrarDevolucion.Text = "Confirmar Devolución";
            this.btnRegistrarDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click);
            // 
            // imgListTabs
            // 
            this.imgListTabs.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListTabs.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListTabs.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmPrestamos
            // 
            this.ClientSize = new System.Drawing.Size(955, 455);
            this.Controls.Add(this.tabControlOperaciones);
            this.Controls.Add(this.groupBoxAlumno);
            this.Name = "frmPrestamos";
            this.Text = "Gestión de Préstamos y Devoluciones";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.groupBoxAlumno.ResumeLayout(false);
            this.groupBoxAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialAlumno)).EndInit();
            this.tabControlOperaciones.ResumeLayout(false);
            this.tabPrestamo.ResumeLayout(false);
            this.tabPrestamo.PerformLayout();
            this.tabDevolucion.ResumeLayout(false);
            this.tabDevolucion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlumno;
        private System.Windows.Forms.Label lblDniLabel;
        private System.Windows.Forms.TextBox txtDniAlumno;
        private FontAwesome.Sharp.IconButton btnBuscarAlumno;
        private System.Windows.Forms.Label lblNombreLabel;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblHistorialLabel;
        private System.Windows.Forms.DataGridView dgvHistorialAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;

        private System.Windows.Forms.TabControl tabControlOperaciones;
        private System.Windows.Forms.TabPage tabPrestamo;
        private System.Windows.Forms.Label lblSeleccionTipo;
        private System.Windows.Forms.CheckBox chkComputadora;
        private System.Windows.Forms.CheckBox chkLibro;
        private System.Windows.Forms.Label lblComputadora;
        private System.Windows.Forms.ComboBox cboComputadoras;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cboLibros;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Label lblRecepcionistaActivo;
        private System.Windows.Forms.Label lblConfirmarClave;
        private System.Windows.Forms.TextBox txtClaveConfirmacion;
        private FontAwesome.Sharp.IconButton btnRegistrar;

        private System.Windows.Forms.TabPage tabDevolucion;
        private System.Windows.Forms.Label lblInfoDevolucion;
        private System.Windows.Forms.Label lblEstadoFisico;
        private System.Windows.Forms.ComboBox cboEstadoFisico;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private FontAwesome.Sharp.IconButton btnRegistrarDevolucion;
        private System.Windows.Forms.ImageList imgListTabs;
    }
}