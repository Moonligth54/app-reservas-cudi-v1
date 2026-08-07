namespace FrontEndforms
{
    partial class Form2
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
            label2 = new Label();
            label1 = new Label();
            panelDatosRecurso = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelDatosRecurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 111, 229);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 90);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(222, 57);
            label2.Name = "label2";
            label2.Size = new Size(192, 17);
            label2.TabIndex = 1;
            label2.Text = "Complete los datos del recurso";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(210, 26);
            label1.Name = "label1";
            label1.Size = new Size(204, 31);
            label1.TabIndex = 0;
            label1.Text = "Nuevo recurso";
            // 
            // panelDatosRecurso
            // 
            panelDatosRecurso.BackColor = SystemColors.Control;
            panelDatosRecurso.Controls.Add(panel2);
            panelDatosRecurso.Controls.Add(button2);
            panelDatosRecurso.Controls.Add(button1);
            panelDatosRecurso.Controls.Add(numericUpDown1);
            panelDatosRecurso.Controls.Add(comboBox1);
            panelDatosRecurso.Controls.Add(textBox2);
            panelDatosRecurso.Controls.Add(textBox1);
            panelDatosRecurso.Controls.Add(label7);
            panelDatosRecurso.Controls.Add(label6);
            panelDatosRecurso.Controls.Add(label5);
            panelDatosRecurso.Controls.Add(label4);
            panelDatosRecurso.Controls.Add(label3);
            panelDatosRecurso.Location = new Point(109, 145);
            panelDatosRecurso.Name = "panelDatosRecurso";
            panelDatosRecurso.Size = new Size(947, 423);
            panelDatosRecurso.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 201, 255);
            panel2.Location = new Point(47, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(824, 2);
            panel2.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.WhiteSmoke;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(800, 364);
            button2.Name = "button2";
            button2.Size = new Size(102, 40);
            button2.TabIndex = 10;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 111, 229);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(677, 364);
            button1.Name = "button1";
            button1.Size = new Size(102, 40);
            button1.TabIndex = 9;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(290, 285);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(297, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(290, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(581, 23);
            comboBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(290, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(581, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(290, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(581, 23);
            textBox1.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 179);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 4;
            label7.Text = "Descripcion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 282);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 3;
            label6.Text = "Cantidad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 136);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 2;
            label5.Text = "Tipo de recurso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 86);
            label4.Name = "label4";
            label4.Size = new Size(161, 21);
            label4.TabIndex = 1;
            label4.Text = "Nombre del recurso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(40, 111, 229);
            label3.Location = new Point(46, 13);
            label3.Name = "label3";
            label3.Size = new Size(183, 30);
            label3.TabIndex = 0;
            label3.Text = "Datos del recurso";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.B5BE072F_A38E_4CC9_9C77_1E549FA76FD0;
            pictureBox1.Location = new Point(-17, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(panelDatosRecurso);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Recurso";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelDatosRecurso.ResumeLayout(false);
            panelDatosRecurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panelDatosRecurso;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}