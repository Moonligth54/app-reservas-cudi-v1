namespace capainicio
{
    partial class frmRecursos
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.id_recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReparado = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(18, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(342, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Equipos en Mantenimiento / Dañados";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(395, 13);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Lista de computadoras y recursos devueltos con daños que requieren reparación.";
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.AllowUserToAddRows = false;
            this.dgvRecursos.AllowUserToDeleteRows = false;
            this.dgvRecursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecursos.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_recurso,
            this.codigo,
            this.tipo_recurso,
            this.estado,
            this.observaciones});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecursos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecursos.EnableHeadersVisualStyles = false;
            this.dgvRecursos.Location = new System.Drawing.Point(22, 75);
            this.dgvRecursos.MultiSelect = false;
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.ReadOnly = true;
            this.dgvRecursos.RowHeadersVisible = false;
            this.dgvRecursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecursos.Size = new System.Drawing.Size(800, 300);
            this.dgvRecursos.TabIndex = 2;
            // 
            // id_recurso
            // 
            this.id_recurso.HeaderText = "ID";
            this.id_recurso.Name = "id_recurso";
            this.id_recurso.ReadOnly = true;
            this.id_recurso.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código / Identificador";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // tipo_recurso
            // 
            this.tipo_recurso.HeaderText = "Tipo de Recurso";
            this.tipo_recurso.Name = "tipo_recurso";
            this.tipo_recurso.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado Actual";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            // 
            // btnReparado
            // 
            this.btnReparado.BackColor = System.Drawing.Color.ForestGreen;
            this.btnReparado.FlatAppearance.BorderSize = 0;
            this.btnReparado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReparado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparado.ForeColor = System.Drawing.Color.White;
            this.btnReparado.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnReparado.IconColor = System.Drawing.Color.White;
            this.btnReparado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReparado.IconSize = 20;
            this.btnReparado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReparado.Location = new System.Drawing.Point(592, 388);
            this.btnReparado.Name = "btnReparado";
            this.btnReparado.Size = new System.Drawing.Size(230, 40);
            this.btnReparado.TabIndex = 3;
            this.btnReparado.Text = "Marcar como Reparado";
            this.btnReparado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReparado.UseVisualStyleBackColor = false;
            this.btnReparado.Click += new System.EventHandler(this.btnReparado_Click);
            // 
            // frmRecursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 450);
            this.Controls.Add(this.btnReparado);
            this.Controls.Add(this.dgvRecursos);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmRecursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Mantenimiento de Recursos";
            this.Load += new System.EventHandler(this.frmRecursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_recurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private FontAwesome.Sharp.IconButton btnReparado;
    }
}