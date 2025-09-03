namespace ProyectoNetshop.formularios
{
    partial class usuarios
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
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label9 = new Label();
            textBox8 = new TextBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            fechaNacimiento = new DateTimePicker();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            panel2 = new Panel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            dataGridView1 = new DataGridView();
            colIdUsuario = new DataGridViewTextBoxColumn();
            colPerfil = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDni = new DataGridViewTextBoxColumn();
            colDireccion = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colFechaNacimiento = new DataGridViewTextBoxColumn();
            colSexo = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(fechaNacimiento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(1046, 219);
            panel1.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(915, 117);
            label12.Name = "label12";
            label12.Size = new Size(54, 22);
            label12.TabIndex = 26;
            label12.Text = "Eliminar";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(915, 17);
            label11.Name = "label11";
            label11.Size = new Size(54, 22);
            label11.TabIndex = 25;
            label11.Text = "Guardar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(729, 154);
            label10.Name = "label10";
            label10.Size = new Size(38, 22);
            label10.TabIndex = 24;
            label10.Text = "Perfil";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Usuario" });
            comboBox1.Location = new Point(662, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(645, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 60);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic);
            radioButton1.ForeColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(17, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(84, 26);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic);
            radioButton2.ForeColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(116, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 26);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(397, 154);
            label9.Name = "label9";
            label9.Size = new Size(58, 22);
            label9.TabIndex = 20;
            label9.Text = "Telefono";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(341, 179);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(183, 23);
            textBox8.TabIndex = 19;
            // 
            // iconButton2
            // 
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(904, 142);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(75, 60);
            iconButton2.TabIndex = 18;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(693, 5);
            label8.Name = "label8";
            label8.Size = new Size(121, 22);
            label8.TabIndex = 17;
            label8.Text = "Fecha de nacimiento";
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Location = new Point(662, 30);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(183, 23);
            fechaNacimiento.TabIndex = 16;
            fechaNacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(397, 105);
            label5.Name = "label5";
            label5.Size = new Size(62, 22);
            label5.TabIndex = 15;
            label5.Text = "Direccion";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(341, 130);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(183, 23);
            textBox5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(408, 54);
            label6.Name = "label6";
            label6.Size = new Size(32, 22);
            label6.TabIndex = 13;
            label6.Text = "DNI";
            label6.Click += label6_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(340, 79);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(183, 23);
            textBox6.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(408, 5);
            label7.Name = "label7";
            label7.Size = new Size(39, 22);
            label7.TabIndex = 11;
            label7.Text = "Email";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(340, 30);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(183, 23);
            textBox7.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(73, 154);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 9;
            label3.Text = "Contraseña";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(83, 105);
            label4.Name = "label4";
            label4.Size = new Size(53, 22);
            label4.TabIndex = 7;
            label4.Text = "Usuario";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(22, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(183, 23);
            textBox4.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(82, 54);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(82, 5);
            label1.Name = "label1";
            label1.Size = new Size(54, 22);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // iconButton1
            // 
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.Location = new Point(904, 42);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(75, 60);
            iconButton1.TabIndex = 2;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 304);
            panel2.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic);
            checkBox2.ForeColor = SystemColors.ButtonFace;
            checkBox2.Location = new Point(232, 19);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(79, 26);
            checkBox2.TabIndex = 30;
            checkBox2.Text = "Inactivos";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Dubai", 9.749999F, FontStyle.Bold | FontStyle.Italic);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Location = new Point(75, 19);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(71, 26);
            checkBox1.TabIndex = 29;
            checkBox1.Text = "Activos";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(0, 0, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colIdUsuario, colPerfil, colNombre, colApellido, colUsuario, colEmail, colDni, colDireccion, colTelefono, colFechaNacimiento, colSexo });
            dataGridView1.Location = new Point(21, 51);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1005, 234);
            dataGridView1.TabIndex = 0;
            // 
            // colIdUsuario
            // 
            colIdUsuario.HeaderText = "idUsuario";
            colIdUsuario.Name = "colIdUsuario";
            // 
            // colPerfil
            // 
            colPerfil.HeaderText = "idPerfil";
            colPerfil.Name = "colPerfil";
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.Name = "colApellido";
            // 
            // colUsuario
            // 
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            // 
            // colDni
            // 
            colDni.HeaderText = "DNI";
            colDni.Name = "colDni";
            // 
            // colDireccion
            // 
            colDireccion.HeaderText = "Direccion";
            colDireccion.Name = "colDireccion";
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telefono";
            colTelefono.Name = "colTelefono";
            // 
            // colFechaNacimiento
            // 
            colFechaNacimiento.HeaderText = "Fecha de nacimiento";
            colFechaNacimiento.Name = "colFechaNacimiento";
            // 
            // colSexo
            // 
            colSexo.HeaderText = "Sexo";
            colSexo.Name = "colSexo";
            // 
            // usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1046, 563);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "usuarios";
            Text = "usuarios";
            Load += usuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private DateTimePicker fechaNacimiento;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Label label8;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label9;
        private TextBox textBox8;
        private Panel panel2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label10;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private DataGridViewTextBoxColumn colIdUsuario;
        private DataGridViewTextBoxColumn colPerfil;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colDni;
        private DataGridViewTextBoxColumn colDireccion;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colFechaNacimiento;
        private DataGridViewTextBoxColumn colSexo;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}