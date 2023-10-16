namespace ClienteServicios
{
    partial class AbmAlumnos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtDNI = new TextBox();
            btnEnviar = new Button();
            label1 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtNotaPromedio = new TextBox();
            txtApellidoNombre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(591, 346);
            dataGridView1.TabIndex = 0;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(728, 68);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(160, 23);
            txtDNI.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(728, 300);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(160, 34);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(692, 68);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 3;
            label1.Text = "DNI:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(728, 214);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(215, 23);
            dtpFechaNacimiento.TabIndex = 4;
            // 
            // txtNotaPromedio
            // 
            txtNotaPromedio.Location = new Point(728, 260);
            txtNotaPromedio.Name = "txtNotaPromedio";
            txtNotaPromedio.Size = new Size(160, 23);
            txtNotaPromedio.TabIndex = 5;
            // 
            // txtApellidoNombre
            // 
            txtApellidoNombre.Location = new Point(728, 117);
            txtApellidoNombre.Name = "txtApellidoNombre";
            txtApellidoNombre.Size = new Size(160, 23);
            txtApellidoNombre.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(728, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 117);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido y Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 167);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 214);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 10;
            label4.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 260);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 11;
            label5.Text = "Nota Promedio:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 364);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(93, 364);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // AbmAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 397);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtApellidoNombre);
            Controls.Add(txtNotaPromedio);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label1);
            Controls.Add(btnEnviar);
            Controls.Add(txtDNI);
            Controls.Add(dataGridView1);
            Name = "AbmAlumnos";
            Text = "AbmAlumnos";
            Load += AbmAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtDNI;
        private Button btnEnviar;
        private Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtNotaPromedio;
        private TextBox txtApellidoNombre;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEditar;
        private Button btnEliminar;
    }
}