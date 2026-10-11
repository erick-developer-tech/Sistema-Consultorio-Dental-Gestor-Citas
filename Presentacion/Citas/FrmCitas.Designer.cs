namespace Presentacion.Citas
{
    partial class FrmCitas
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
            groupBox1 = new GroupBox();
            comboBoxUsuario = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBoxPaciente = new ComboBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            textBoxCosto = new TextBox();
            label6 = new Label();
            comboBoxServicio = new ComboBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            textBoxNotas = new TextBox();
            label7 = new Label();
            comboBoxEstado = new ComboBox();
            label5 = new Label();
            dateTimePickerFechaHora = new DateTimePicker();
            label4 = new Label();
            dataGridViewLista = new DataGridView();
            label8 = new Label();
            dateTimePickerFechaInicio = new DateTimePicker();
            label9 = new Label();
            dateTimePickerFechaFin = new DateTimePicker();
            buttonRefrescar = new Button();
            buttonBuscar = new Button();
            labelTotal = new Label();
            buttonEliminar = new Button();
            buttonPagado = new Button();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            buttonNuevo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // comboBoxUsuario
            // 
            comboBoxUsuario.BackColor = Color.LightBlue;
            comboBoxUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUsuario.FormattingEnabled = true;
            comboBoxUsuario.Location = new Point(6, 57);
            comboBoxUsuario.Name = "comboBoxUsuario";
            comboBoxUsuario.Size = new Size(242, 23);
            comboBoxUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxPaciente);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(338, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 126);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Paciente";
            // 
            // comboBoxPaciente
            // 
            comboBoxPaciente.BackColor = Color.LightBlue;
            comboBoxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPaciente.FormattingEnabled = true;
            comboBoxPaciente.Location = new Point(6, 57);
            comboBoxPaciente.Name = "comboBoxPaciente";
            comboBoxPaciente.Size = new Size(242, 23);
            comboBoxPaciente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Paciente:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxCosto);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(comboBoxServicio);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(664, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 126);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Servicio";
            // 
            // textBoxCosto
            // 
            textBoxCosto.BackColor = Color.LightBlue;
            textBoxCosto.Location = new Point(53, 92);
            textBoxCosto.Name = "textBoxCosto";
            textBoxCosto.ReadOnly = true;
            textBoxCosto.Size = new Size(129, 23);
            textBoxCosto.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 95);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 4;
            label6.Text = "Costo:";
            // 
            // comboBoxServicio
            // 
            comboBoxServicio.BackColor = Color.LightBlue;
            comboBoxServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxServicio.FormattingEnabled = true;
            comboBoxServicio.Location = new Point(6, 57);
            comboBoxServicio.Name = "comboBoxServicio";
            comboBoxServicio.Size = new Size(242, 23);
            comboBoxServicio.TabIndex = 3;
            comboBoxServicio.SelectedIndexChanged += comboBoxServicio_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 30);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Servicio:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(textBoxNotas);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(comboBoxEstado);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(dateTimePickerFechaHora);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(12, 144);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(646, 103);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Datos Generales de la Cita";
            // 
            // textBoxNotas
            // 
            textBoxNotas.BackColor = Color.LightBlue;
            textBoxNotas.Location = new Point(332, 25);
            textBoxNotas.Multiline = true;
            textBoxNotas.Name = "textBoxNotas";
            textBoxNotas.Size = new Size(308, 64);
            textBoxNotas.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 25);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 5;
            label7.Text = "Notas:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.BackColor = Color.LightBlue;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "Agendada", "Completada", "Cancelada" });
            comboBoxEstado.Location = new Point(57, 66);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(191, 23);
            comboBoxEstado.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 2;
            label5.Text = "Estado:";
            // 
            // dateTimePickerFechaHora
            // 
            dateTimePickerFechaHora.CalendarMonthBackground = Color.LightBlue;
            dateTimePickerFechaHora.CustomFormat = "yyyy/MM/dd HH:mm";
            dateTimePickerFechaHora.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaHora.Location = new Point(91, 19);
            dateTimePickerFechaHora.Name = "dateTimePickerFechaHora";
            dateTimePickerFechaHora.Size = new Size(157, 23);
            dateTimePickerFechaHora.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = "Fecha y Hora:";
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToAddRows = false;
            dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewLista.AllowUserToResizeColumns = false;
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(12, 298);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(972, 280);
            dataGridViewLista.TabIndex = 45;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 263);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 46;
            label8.Text = "Fecha Inicio:";
            // 
            // dateTimePickerFechaInicio
            // 
            dateTimePickerFechaInicio.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaInicio.Location = new Point(91, 257);
            dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            dateTimePickerFechaInicio.Size = new Size(125, 23);
            dateTimePickerFechaInicio.TabIndex = 47;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(233, 263);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 48;
            label9.Text = "Fecha Fin:";
            // 
            // dateTimePickerFechaFin
            // 
            dateTimePickerFechaFin.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaFin.Location = new Point(299, 257);
            dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            dateTimePickerFechaFin.Size = new Size(125, 23);
            dateTimePickerFechaFin.TabIndex = 49;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(521, 257);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 51;
            buttonRefrescar.Text = "Cargar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(440, 257);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 50;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(12, 581);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(79, 15);
            labelTotal.TabIndex = 52;
            labelTotal.Text = "Total de citas:";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(913, 593);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(69, 23);
            buttonEliminar.TabIndex = 53;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonPagado
            // 
            buttonPagado.Location = new Point(774, 593);
            buttonPagado.Name = "buttonPagado";
            buttonPagado.Size = new Size(133, 23);
            buttonPagado.TabIndex = 54;
            buttonPagado.Text = "Marcar como pagado";
            buttonPagado.UseVisualStyleBackColor = true;
            buttonPagado.Click += buttonPagado_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(832, 161);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 57;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(751, 161);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 56;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(670, 161);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 55;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // FrmCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 628);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonPagado);
            Controls.Add(buttonEliminar);
            Controls.Add(labelTotal);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonBuscar);
            Controls.Add(dateTimePickerFechaFin);
            Controls.Add(label9);
            Controls.Add(dateTimePickerFechaInicio);
            Controls.Add(label8);
            Controls.Add(dataGridViewLista);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCitas";
            Text = "Citas";
            Load += FrmCitas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxPaciente;
        private ComboBox comboBoxUsuario;
        private ComboBox comboBoxEstado;
        private Label label5;
        private DateTimePicker dateTimePickerFechaHora;
        private Label label4;
        private TextBox textBoxCosto;
        private Label label6;
        private ComboBox comboBoxServicio;
        private TextBox textBoxNotas;
        private Label label7;
        private DataGridView dataGridViewLista;
        private Label label8;
        private DateTimePicker dateTimePickerFechaInicio;
        private Label label9;
        private DateTimePicker dateTimePickerFechaFin;
        private Button buttonRefrescar;
        private Button buttonBuscar;
        private Label labelTotal;
        private Button buttonEliminar;
        private Button buttonPagado;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private Button buttonNuevo;
    }
}