namespace Presentacion.Pacientes
{
    partial class FrmPaciente
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
            textBoxEmail = new TextBox();
            textBoxTelefono = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxAlergias = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(324, 277);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(105, 15);
            labelTotal.TabIndex = 27;
            labelTotal.Text = "Total de pacientes:";
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(820, 18);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 26;
            buttonRefrescar.Text = "Cargar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(820, 277);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 25;
            buttonEliminar.Text = "Eliminar";
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
            dataGridViewLista.Location = new Point(324, 59);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(571, 204);
            dataGridViewLista.TabIndex = 24;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(739, 18);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 23;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(377, 20);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese el nombre de un paciente para buscar.";
            textBoxBuscar.Size = new Size(312, 23);
            textBoxBuscar.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 23);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 21;
            label3.Text = "Buscar:";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.BackColor = Color.LightBlue;
            textBoxApellidos.Location = new Point(82, 59);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(218, 23);
            textBoxApellidos.TabIndex = 20;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.LightBlue;
            textBoxNombre.Location = new Point(74, 19);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(226, 23);
            textBoxNombre.TabIndex = 19;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(174, 269);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(93, 269);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 17;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(12, 269);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 16;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 15;
            label2.Text = "Apellidos*:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 14;
            label1.Text = "Nombre*:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.LightBlue;
            textBoxEmail.Location = new Point(62, 141);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(218, 23);
            textBoxEmail.TabIndex = 31;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BackColor = Color.LightBlue;
            textBoxTelefono.Location = new Point(74, 101);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(226, 23);
            textBoxTelefono.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 29;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 104);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 28;
            label5.Text = "Telefono*:";
            // 
            // textBoxAlergias
            // 
            textBoxAlergias.BackColor = Color.LightBlue;
            textBoxAlergias.Location = new Point(74, 184);
            textBoxAlergias.Multiline = true;
            textBoxAlergias.Name = "textBoxAlergias";
            textBoxAlergias.Size = new Size(226, 66);
            textBoxAlergias.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 187);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 32;
            label6.Text = "Alergias:";
            // 
            // FrmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 312);
            Controls.Add(textBoxAlergias);
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
            Name = "FrmPaciente";
            Text = "Pacientes";
            Load += FrmPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TextBox textBoxEmail;
        private TextBox textBoxTelefono;
        private Label label4;
        private Label label5;
        private TextBox textBoxAlergias;
        private Label label6;
    }
}