namespace Presentacion.Recetas
{
    partial class FrmRecetas
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
            dataGridViewLista = new DataGridView();
            groupBox1 = new GroupBox();
            comboBoxCita = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBoxTratamiento = new TextBox();
            textBoxDiagnostico = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBoxBuscar = new TextBox();
            label9 = new Label();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            buttonNuevo = new Button();
            buttonRefrescar = new Button();
            buttonBuscar = new Button();
            labelTotal = new Label();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToAddRows = false;
            dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewLista.AllowUserToResizeColumns = false;
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(12, 203);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(875, 280);
            dataGridViewLista.TabIndex = 46;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxCita);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 126);
            groupBox1.TabIndex = 47;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cita";
            // 
            // comboBoxCita
            // 
            comboBoxCita.BackColor = Color.LightBlue;
            comboBoxCita.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCita.FormattingEnabled = true;
            comboBoxCita.Location = new Point(6, 57);
            comboBoxCita.Name = "comboBoxCita";
            comboBoxCita.Size = new Size(308, 23);
            comboBoxCita.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Selecciona una cita:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxTratamiento);
            groupBox2.Controls.Add(textBoxDiagnostico);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(338, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(547, 126);
            groupBox2.TabIndex = 48;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos Generales de la Receta";
            // 
            // textBoxTratamiento
            // 
            textBoxTratamiento.BackColor = Color.LightBlue;
            textBoxTratamiento.Location = new Point(276, 57);
            textBoxTratamiento.Multiline = true;
            textBoxTratamiento.Name = "textBoxTratamiento";
            textBoxTratamiento.Size = new Size(256, 63);
            textBoxTratamiento.TabIndex = 3;
            // 
            // textBoxDiagnostico
            // 
            textBoxDiagnostico.BackColor = Color.LightBlue;
            textBoxDiagnostico.Location = new Point(6, 57);
            textBoxDiagnostico.Multiline = true;
            textBoxDiagnostico.Name = "textBoxDiagnostico";
            textBoxDiagnostico.Size = new Size(256, 63);
            textBoxDiagnostico.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 30);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 1;
            label3.Text = "Tratamiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Diagnostico:";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(63, 162);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingresa el nombre de un paciente para encontrar su receta.";
            textBoxBuscar.Size = new Size(354, 23);
            textBoxBuscar.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 165);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 50;
            label9.Text = "Buscar:";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(811, 162);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 60;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(730, 162);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 59;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(649, 162);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 58;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(504, 162);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 62;
            buttonRefrescar.Text = "Cargar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(423, 162);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 61;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(12, 486);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(92, 15);
            labelTotal.TabIndex = 63;
            labelTotal.Text = "Total de recetas:";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(817, 489);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(69, 23);
            buttonEliminar.TabIndex = 64;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // FrmRecetas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 523);
            Controls.Add(buttonEliminar);
            Controls.Add(labelTotal);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label9);
            Controls.Add(textBoxBuscar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridViewLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRecetas";
            Text = "Recetas";
            Load += FrmRecetas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLista;
        private GroupBox groupBox1;
        private ComboBox comboBoxCita;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox textBoxTratamiento;
        private TextBox textBoxDiagnostico;
        private TextBox textBoxBuscar;
        private Label label9;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private Button buttonNuevo;
        private Button buttonRefrescar;
        private Button buttonBuscar;
        private Label labelTotal;
        private Button buttonEliminar;
    }
}