namespace SistemaEstudiantes
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNControl = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNControl = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxEstudiante = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelPaginador = new System.Windows.Forms.Label();
            this.buttonUltimaPag = new System.Windows.Forms.Button();
            this.buttonSigPag = new System.Windows.Forms.Button();
            this.buttonAnteriorPag = new System.Windows.Forms.Button();
            this.buttonPrimeraPag = new System.Windows.Forms.Button();
            this.dataGridViewEstudiantes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstudiante)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-6, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(289, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de estudiantes";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.buttonAgregar);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.textBoxNControl);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Controls.Add(this.labelNControl);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(4, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.ForeColor = System.Drawing.Color.Turquoise;
            this.buttonCancelar.Image = global::SistemaEstudiantes.Properties.Resources.baseline_cancel_white_18dp;
            this.buttonCancelar.Location = new System.Drawing.Point(250, 272);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(88, 43);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminar.Image = global::SistemaEstudiantes.Properties.Resources.baseline_delete_forever_white_18dp;
            this.buttonEliminar.Location = new System.Drawing.Point(142, 272);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(88, 43);
            this.buttonEliminar.TabIndex = 6;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Información del estudiante";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Lime;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.ForeColor = System.Drawing.Color.Lime;
            this.buttonAgregar.Image = global::SistemaEstudiantes.Properties.Resources.baseline_person_add_white_18dp;
            this.buttonAgregar.Location = new System.Drawing.Point(28, 272);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(88, 43);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(191, 232);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(147, 20);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(18, 232);
            this.textBoxApellido.Multiline = true;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(148, 20);
            this.textBoxApellido.TabIndex = 3;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(191, 177);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(147, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxNControl
            // 
            this.textBoxNControl.Location = new System.Drawing.Point(18, 177);
            this.textBoxNControl.Multiline = true;
            this.textBoxNControl.Name = "textBoxNControl";
            this.textBoxNControl.Size = new System.Drawing.Size(148, 20);
            this.textBoxNControl.TabIndex = 1;
            this.textBoxNControl.TextChanged += new System.EventHandler(this.textBoxNControl_TextChanged);
            this.textBoxNControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNControl_KeyPress);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelEmail.Location = new System.Drawing.Point(188, 214);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 16);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelApellido.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelApellido.Location = new System.Drawing.Point(14, 214);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(58, 17);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNombre.Location = new System.Drawing.Point(188, 157);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelNControl
            // 
            this.labelNControl.AutoSize = true;
            this.labelNControl.BackColor = System.Drawing.Color.White;
            this.labelNControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNControl.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelNControl.Location = new System.Drawing.Point(15, 157);
            this.labelNControl.Name = "labelNControl";
            this.labelNControl.Size = new System.Drawing.Size(63, 17);
            this.labelNControl.TabIndex = 1;
            this.labelNControl.Text = "NControl";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxEstudiante);
            this.groupBox5.Location = new System.Drawing.Point(105, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(134, 116);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            // 
            // pictureBoxEstudiante
            // 
            this.pictureBoxEstudiante.Image = global::SistemaEstudiantes.Properties.Resources.baseline_add_a_photo_black_48dp;
            this.pictureBoxEstudiante.Location = new System.Drawing.Point(16, 13);
            this.pictureBoxEstudiante.Name = "pictureBoxEstudiante";
            this.pictureBoxEstudiante.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEstudiante.TabIndex = 0;
            this.pictureBoxEstudiante.TabStop = false;
            this.pictureBoxEstudiante.Click += new System.EventHandler(this.pictureBoxEstudiante_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.labelPaginador);
            this.groupBox3.Controls.Add(this.buttonUltimaPag);
            this.groupBox3.Controls.Add(this.buttonSigPag);
            this.groupBox3.Controls.Add(this.buttonAnteriorPag);
            this.groupBox3.Controls.Add(this.buttonPrimeraPag);
            this.groupBox3.Controls.Add(this.dataGridViewEstudiantes);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(368, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 325);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(20, 272);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelPaginador
            // 
            this.labelPaginador.AutoSize = true;
            this.labelPaginador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaginador.Location = new System.Drawing.Point(191, 248);
            this.labelPaginador.Name = "labelPaginador";
            this.labelPaginador.Size = new System.Drawing.Size(65, 16);
            this.labelPaginador.TabIndex = 9;
            this.labelPaginador.Text = "Paginas";
            // 
            // buttonUltimaPag
            // 
            this.buttonUltimaPag.BackColor = System.Drawing.Color.White;
            this.buttonUltimaPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUltimaPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonUltimaPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUltimaPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimaPag.ForeColor = System.Drawing.Color.White;
            this.buttonUltimaPag.Image = global::SistemaEstudiantes.Properties.Resources.baseline_last_page_black_18dp;
            this.buttonUltimaPag.Location = new System.Drawing.Point(269, 273);
            this.buttonUltimaPag.Name = "buttonUltimaPag";
            this.buttonUltimaPag.Size = new System.Drawing.Size(40, 20);
            this.buttonUltimaPag.TabIndex = 12;
            this.buttonUltimaPag.UseVisualStyleBackColor = false;
            this.buttonUltimaPag.Click += new System.EventHandler(this.buttonUltimaPag_Click);
            // 
            // buttonSigPag
            // 
            this.buttonSigPag.BackColor = System.Drawing.Color.White;
            this.buttonSigPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSigPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSigPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSigPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSigPag.ForeColor = System.Drawing.Color.White;
            this.buttonSigPag.Image = global::SistemaEstudiantes.Properties.Resources.baseline_chevron_right_black_18dp;
            this.buttonSigPag.Location = new System.Drawing.Point(225, 272);
            this.buttonSigPag.Name = "buttonSigPag";
            this.buttonSigPag.Size = new System.Drawing.Size(40, 20);
            this.buttonSigPag.TabIndex = 11;
            this.buttonSigPag.UseVisualStyleBackColor = false;
            this.buttonSigPag.Click += new System.EventHandler(this.buttonSigPag_Click);
            // 
            // buttonAnteriorPag
            // 
            this.buttonAnteriorPag.BackColor = System.Drawing.Color.White;
            this.buttonAnteriorPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnteriorPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonAnteriorPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAnteriorPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnteriorPag.ForeColor = System.Drawing.Color.White;
            this.buttonAnteriorPag.Image = global::SistemaEstudiantes.Properties.Resources.baseline_chevron_left_black_18dp;
            this.buttonAnteriorPag.Location = new System.Drawing.Point(180, 272);
            this.buttonAnteriorPag.Name = "buttonAnteriorPag";
            this.buttonAnteriorPag.Size = new System.Drawing.Size(40, 20);
            this.buttonAnteriorPag.TabIndex = 10;
            this.buttonAnteriorPag.UseVisualStyleBackColor = false;
            this.buttonAnteriorPag.Click += new System.EventHandler(this.buttonAnteriorPag_Click);
            // 
            // buttonPrimeraPag
            // 
            this.buttonPrimeraPag.BackColor = System.Drawing.Color.White;
            this.buttonPrimeraPag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrimeraPag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPrimeraPag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPrimeraPag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrimeraPag.ForeColor = System.Drawing.Color.White;
            this.buttonPrimeraPag.Image = global::SistemaEstudiantes.Properties.Resources.baseline_first_page_black_18dp;
            this.buttonPrimeraPag.Location = new System.Drawing.Point(142, 272);
            this.buttonPrimeraPag.Name = "buttonPrimeraPag";
            this.buttonPrimeraPag.Size = new System.Drawing.Size(40, 20);
            this.buttonPrimeraPag.TabIndex = 8;
            this.buttonPrimeraPag.UseVisualStyleBackColor = false;
            this.buttonPrimeraPag.Click += new System.EventHandler(this.buttonPrimeraPag_Click);
            // 
            // dataGridViewEstudiantes
            // 
            this.dataGridViewEstudiantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstudiantes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridViewEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstudiantes.Location = new System.Drawing.Point(6, 39);
            this.dataGridViewEstudiantes.Name = "dataGridViewEstudiantes";
            this.dataGridViewEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstudiantes.Size = new System.Drawing.Size(453, 206);
            this.dataGridViewEstudiantes.TabIndex = 9;
            this.dataGridViewEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstudiantes_CellClick);
            this.dataGridViewEstudiantes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEstudiantes_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lista de estudiantes";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.textBoxBuscar);
            this.groupBox4.Controls.Add(this.labelBuscar);
            this.groupBox4.Location = new System.Drawing.Point(12, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(821, 67);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(542, 31);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(129, 20);
            this.textBoxBuscar.TabIndex = 8;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.Location = new System.Drawing.Point(464, 31);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(65, 20);
            this.labelBuscar.TabIndex = 1;
            this.labelBuscar.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstudiante)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstudiantes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNControl;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNControl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBoxEstudiante;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewEstudiantes;
        private System.Windows.Forms.Button buttonPrimeraPag;
        private System.Windows.Forms.Button buttonAnteriorPag;
        private System.Windows.Forms.Button buttonSigPag;
        private System.Windows.Forms.Button buttonUltimaPag;
        private System.Windows.Forms.Label labelPaginador;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

