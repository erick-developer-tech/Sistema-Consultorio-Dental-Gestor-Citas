namespace Presentacion.Usuarios
{
    partial class FrmUsuarios
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
            textBoxHorario = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            textBoxTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            labelTotal = new Label();
            buttonRefrescar = new Button();
            buttonEliminar = new Button();
            dataGridViewLista = new DataGridView();
            buttonBuscar = new Button();
            textBoxBuscar = new TextBox();
            label3 = new Label();
            textBoxApellidos = new TextBox();
            textBoxNombre = new TextBox();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            buttonNuevo = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxContraseña = new TextBox();
            label7 = new Label();
            textBoxUsuario = new TextBox();
            label8 = new Label();
            label9 = new Label();
            comboBoxRol = new ComboBox();
            buttonActualizarUC = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // textBoxHorario
            // 
            textBoxHorario.BackColor = Color.LightBlue;
            textBoxHorario.Location = new Point(74, 181);
            textBoxHorario.Name = "textBoxHorario";
            textBoxHorario.Size = new Size(226, 23);
            textBoxHorario.TabIndex = 53;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 184);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 52;
            label6.Text = "Horario*:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.LightBlue;
            textBoxEmail.Location = new Point(62, 138);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(218, 23);
            textBoxEmail.TabIndex = 51;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BackColor = Color.LightBlue;
            textBoxTelefono.Location = new Point(74, 98);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(226, 23);
            textBoxTelefono.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 141);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 49;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 101);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 48;
            label5.Text = "Telefono*:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(324, 396);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(99, 15);
            labelTotal.TabIndex = 47;
            labelTotal.Text = "Total de usuarios:";
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(778, 17);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 46;
            buttonRefrescar.Text = "Cargar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(910, 392);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(97, 23);
            buttonEliminar.TabIndex = 45;
            buttonEliminar.Text = "Eliminar/Baja Usuario";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToAddRows = false;
            dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewLista.AllowUserToResizeColumns = false;
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(324, 56);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(683, 330);
            dataGridViewLista.TabIndex = 44;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(697, 17);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 43;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(377, 17);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese el nombre de un usuario para buscar.";
            textBoxBuscar.Size = new Size(312, 23);
            textBoxBuscar.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 20);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 41;
            label3.Text = "Buscar:";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.BackColor = Color.LightBlue;
            textBoxApellidos.Location = new Point(82, 56);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(218, 23);
            textBoxApellidos.TabIndex = 40;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.LightBlue;
            textBoxNombre.Location = new Point(74, 16);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(226, 23);
            textBoxNombre.TabIndex = 39;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(176, 363);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 38;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(95, 363);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 37;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(14, 363);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 36;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 35;
            label2.Text = "Apellidos*:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 34;
            label1.Text = "Nombre*:";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.LightBlue;
            textBoxContraseña.Location = new Point(92, 271);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(175, 23);
            textBoxContraseña.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 274);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 56;
            label7.Text = "Contraseña*:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.LightBlue;
            textBoxUsuario.Location = new Point(73, 228);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(194, 23);
            textBoxUsuario.TabIndex = 55;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 231);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 54;
            label8.Text = "Usuario*:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 315);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 58;
            label9.Text = "Rol*:";
            // 
            // comboBoxRol
            // 
            comboBoxRol.BackColor = Color.LightBlue;
            comboBoxRol.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Administrador", "Dentista", "Asistente" });
            comboBoxRol.Location = new Point(50, 312);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(184, 23);
            comboBoxRol.TabIndex = 59;
            // 
            // buttonActualizarUC
            // 
            buttonActualizarUC.Location = new Point(750, 392);
            buttonActualizarUC.Name = "buttonActualizarUC";
            buttonActualizarUC.Size = new Size(154, 23);
            buttonActualizarUC.TabIndex = 60;
            buttonActualizarUC.Text = "Actualizar Credenciales";
            buttonActualizarUC.UseVisualStyleBackColor = true;
            buttonActualizarUC.Click += buttonActualizarUC_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 427);
            Controls.Add(buttonActualizarUC);
            Controls.Add(comboBoxRol);
            Controls.Add(label9);
            Controls.Add(textBoxContraseña);
            Controls.Add(label7);
            Controls.Add(textBoxUsuario);
            Controls.Add(label8);
            Controls.Add(textBoxHorario);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxTelefono);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(labelTotal);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonEliminar);
            Controls.Add(dataGridViewLista);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label3);
            Controls.Add(textBoxApellidos);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUsuarios";
            Text = "Usuarios";
            Load += FrmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHorario;
        private Label label6;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefono;
        private Label label4;
        private Label label5;
        private Label labelTotal;
        private Button buttonRefrescar;
        private Button buttonEliminar;
        private DataGridView dataGridViewLista;
        private Button buttonBuscar;
        private TextBox textBoxBuscar;
        private Label label3;
        private TextBox textBoxApellidos;
        private TextBox textBoxNombre;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private Button buttonNuevo;
        private Label label2;
        private Label label1;
        private TextBox textBoxContraseña;
        private Label label7;
        private TextBox textBoxUsuario;
        private Label label8;
        private Label label9;
        private ComboBox comboBoxRol;
        private Button buttonActualizarUC;
    }
}