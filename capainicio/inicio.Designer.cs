namespace capainicio
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusuario = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.menuprestamo = new FontAwesome.Sharp.IconMenuItem();
            this.menureserva = new FontAwesome.Sharp.IconMenuItem();
            this.menumaquinas = new FontAwesome.Sharp.IconMenuItem();
            this.menulibros = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.btnPerfil = new FontAwesome.Sharp.IconButton();
            this.pnlPerfil = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.menuhistorial = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.pnlPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusuario,
            this.menumantenedor,
            this.menuprestamo,
            this.menureserva,
            this.menumaquinas,
            this.menulibros,
            this.menuhistorial,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 71);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(884, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuusuario
            // 
            this.menuusuario.AutoSize = false;
            this.menuusuario.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuusuario.IconColor = System.Drawing.Color.Black;
            this.menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusuario.IconSize = 50;
            this.menuusuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusuario.Name = "menuusuario";
            this.menuusuario.Size = new System.Drawing.Size(80, 69);
            this.menuusuario.Text = "Usuarios";
            this.menuusuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            //this.menuusuario.Click += new System.EventHandler(this.menuusuario_Click);
            // 
            // menumantenedor
            // 
            this.menumantenedor.AutoSize = false;
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 50;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(80, 69);
            this.menumantenedor.Text = "Mantenedor";
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menumantenedor.Click += new System.EventHandler(this.menumantenedor_Click);
            // 
            // menuprestamo
            // 
            this.menuprestamo.AutoSize = false;
            this.menuprestamo.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.menuprestamo.IconColor = System.Drawing.Color.Black;
            this.menuprestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuprestamo.IconSize = 50;
            this.menuprestamo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuprestamo.Name = "menuprestamo";
            this.menuprestamo.Size = new System.Drawing.Size(80, 69);
            this.menuprestamo.Text = "Préstamos";
            this.menuprestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuprestamo.Click += new System.EventHandler(this.menuprestamo_Click);
            // 
            // menureserva
            // 
            this.menureserva.AutoSize = false;
            this.menureserva.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.menureserva.IconColor = System.Drawing.Color.Black;
            this.menureserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureserva.IconSize = 50;
            this.menureserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureserva.Name = "menureserva";
            this.menureserva.Size = new System.Drawing.Size(80, 69);
            this.menureserva.Text = "Reservas";
            this.menureserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menumaquinas
            // 
            this.menumaquinas.AutoSize = false;
            this.menumaquinas.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.menumaquinas.IconColor = System.Drawing.Color.Black;
            this.menumaquinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumaquinas.IconSize = 50;
            this.menumaquinas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumaquinas.Name = "menumaquinas";
            this.menumaquinas.Size = new System.Drawing.Size(80, 69);
            this.menumaquinas.Text = "Máquinas";
            this.menumaquinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menumaquinas.Click += new System.EventHandler(this.menumaquinas_Click);
            // 
            // menulibros
            // 
            this.menulibros.AutoSize = false;
            this.menulibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.menulibros.IconColor = System.Drawing.Color.Black;
            this.menulibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menulibros.IconSize = 50;
            this.menulibros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menulibros.Name = "menulibros";
            this.menulibros.Size = new System.Drawing.Size(80, 69);
            this.menulibros.Text = "Libros";
            this.menulibros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menulibros.Click += new System.EventHandler(this.menulibros_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(80, 69);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(884, 71);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menutitulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Prestamos";
            // 
            // contenedor
            // 
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 144);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(884, 467);
            this.contenedor.TabIndex = 3;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPerfil.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnPerfil.IconColor = System.Drawing.Color.White;
            this.btnPerfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfil.IconSize = 45;
            this.btnPerfil.Location = new System.Drawing.Point(810, 10);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(60, 50);
            this.btnPerfil.TabIndex = 5;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // pnlPerfil
            // 
            this.pnlPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPerfil.BackColor = System.Drawing.Color.White;
            this.pnlPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPerfil.Controls.Add(this.btnCerrarSesion);
            this.pnlPerfil.Controls.Add(this.lblCorreo);
            this.pnlPerfil.Controls.Add(this.lblDni);
            this.pnlPerfil.Controls.Add(this.lblNombreCompleto);
            this.pnlPerfil.Location = new System.Drawing.Point(671, 71);
            this.pnlPerfil.Name = "pnlPerfil";
            this.pnlPerfil.Size = new System.Drawing.Size(213, 150);
            this.pnlPerfil.TabIndex = 6;
            this.pnlPerfil.Visible = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Firebrick;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(22, 105);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(175, 28);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(19, 75);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(19, 48);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(19, 20);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(110, 13);
            this.lblNombreCompleto.TabIndex = 0;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // menuhistorial
            // 
            this.menuhistorial.AutoSize = false;
            this.menuhistorial.IconChar = FontAwesome.Sharp.IconChar.History;
            this.menuhistorial.IconColor = System.Drawing.Color.Black;
            this.menuhistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuhistorial.IconSize = 50;
            this.menuhistorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuhistorial.Name = "menuhistorial";
            this.menuhistorial.Size = new System.Drawing.Size(122, 69);
            this.menuhistorial.Text = "Historial";
            this.menuhistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuhistorial.Click += new System.EventHandler(this.menuhistorial_Click); // <-- AGREGAR ESTA LÍNEA
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.pnlPerfil);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Préstamos";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pnlPerfil.ResumeLayout(false);
            this.pnlPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuprestamo;
        private FontAwesome.Sharp.IconMenuItem menureserva;
        private FontAwesome.Sharp.IconMenuItem menumaquinas;
        private FontAwesome.Sharp.IconMenuItem menulibros;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconButton btnPerfil;
        private System.Windows.Forms.Panel pnlPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombreCompleto;
        private FontAwesome.Sharp.IconMenuItem menuhistorial;
    }
}