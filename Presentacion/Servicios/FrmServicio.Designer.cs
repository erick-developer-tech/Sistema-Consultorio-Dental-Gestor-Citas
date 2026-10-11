namespace Presentacion.Servicios
{
    partial class FrmServicio
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
            label1 = new Label();
            label2 = new Label();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            textBoxServicio = new TextBox();
            textBoxCosto = new TextBox();
            label3 = new Label();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            dataGridViewLista = new DataGridView();
            buttonEliminar = new Button();
            buttonRefrescar = new Button();
            labelTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Servicio*:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Costo*:";
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(12, 110);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(75, 23);
            buttonNuevo.TabIndex = 2;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(93, 110);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 3;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(174, 110);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxServicio
            // 
            textBoxServicio.BackColor = Color.LightBlue;
            textBoxServicio.Location = new Point(74, 24);
            textBoxServicio.Name = "textBoxServicio";
            textBoxServicio.Size = new Size(175, 23);
            textBoxServicio.TabIndex = 5;
            // 
            // textBoxCosto
            // 
            textBoxCosto.BackColor = Color.LightBlue;
            textBoxCosto.Location = new Point(64, 64);
            textBoxCosto.Name = "textBoxCosto";
            textBoxCosto.Size = new Size(100, 23);
            textBoxCosto.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 27);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Buscar:";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(324, 24);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.PlaceholderText = "Ingrese el nombre de un servicio para buscar.";
            textBoxBuscar.Size = new Size(257, 23);
            textBoxBuscar.TabIndex = 8;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(587, 23);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 9;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridViewLista
            // 
            dataGridViewLista.AllowUserToAddRows = false;
            dataGridViewLista.AllowUserToDeleteRows = false;
            dataGridViewLista.AllowUserToResizeColumns = false;
            dataGridViewLista.AllowUserToResizeRows = false;
            dataGridViewLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLista.Location = new Point(273, 64);
            dataGridViewLista.Name = "dataGridViewLista";
            dataGridViewLista.RowHeadersVisible = false;
            dataGridViewLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLista.Size = new Size(472, 175);
            dataGridViewLista.TabIndex = 10;
            dataGridViewLista.DoubleClick += dataGridViewLista_DoubleClick;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(670, 253);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(75, 23);
            buttonEliminar.TabIndex = 11;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonRefrescar
            // 
            buttonRefrescar.Location = new Point(670, 23);
            buttonRefrescar.Name = "buttonRefrescar";
            buttonRefrescar.Size = new Size(75, 23);
            buttonRefrescar.TabIndex = 12;
            buttonRefrescar.Text = "Cargar";
            buttonRefrescar.UseVisualStyleBackColor = true;
            buttonRefrescar.Click += buttonRefrescar_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(273, 253);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(100, 15);
            labelTotal.TabIndex = 13;
            labelTotal.Text = "Total de servicios:";
            // 
            // FrmServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 288);
            Controls.Add(labelTotal);
            Controls.Add(buttonRefrescar);
            Controls.Add(buttonEliminar);
            Controls.Add(dataGridViewLista);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label3);
            Controls.Add(textBoxCosto);
            Controls.Add(textBoxServicio);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmServicio";
            Text = "Servicios";
            Load += FrmServicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private TextBox textBoxServicio;
        private TextBox textBoxCosto;
        private Label label3;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private DataGridView dataGridViewLista;
        private Button buttonEliminar;
        private Button buttonRefrescar;
        private Label labelTotal;
    }
}