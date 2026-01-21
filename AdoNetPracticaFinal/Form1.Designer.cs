namespace AdoNetPracticaFinal
{
    partial class Form1
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtLocalidad = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lstEmpleados = new ListBox();
            cbDepartamentos = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtSalario = new TextBox();
            txtOficio = new TextBox();
            txtApellido = new TextBox();
            btnInsertar = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 251);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 19;
            label5.Text = "Localidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 184);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 117);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 17;
            label3.Text = "ID";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(28, 269);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 214);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new Point(28, 135);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 14;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(242, 70);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(253, 229);
            lstEmpleados.TabIndex = 13;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // cbDepartamentos
            // 
            cbDepartamentos.FormattingEnabled = true;
            cbDepartamentos.Location = new Point(28, 39);
            cbDepartamentos.Name = "cbDepartamentos";
            cbDepartamentos.Size = new Size(162, 23);
            cbDepartamentos.TabIndex = 12;
            cbDepartamentos.SelectedIndexChanged += cbDepartamentos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 21);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 11;
            label2.Text = "Empleados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 10;
            label1.Text = "Departamentos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 209);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 25;
            label6.Text = "Salario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(574, 142);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 24;
            label7.Text = "Oficio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(574, 75);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 23;
            label8.Text = "Apellidos";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(574, 227);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(100, 23);
            txtSalario.TabIndex = 22;
            // 
            // txtOficio
            // 
            txtOficio.Location = new Point(574, 172);
            txtOficio.Name = "txtOficio";
            txtOficio.Size = new Size(100, 23);
            txtOficio.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(574, 93);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 20;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(28, 339);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(127, 46);
            btnInsertar.TabIndex = 26;
            btnInsertar.Text = "Insertar Departamento";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(574, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 40);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsertar);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtSalario);
            Controls.Add(txtOficio);
            Controls.Add(txtApellido);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lstEmpleados);
            Controls.Add(cbDepartamentos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtLocalidad;
        private TextBox txtNombre;
        private TextBox txtId;
        private ListBox lstEmpleados;
        private ComboBox cbDepartamentos;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSalario;
        private TextBox txtOficio;
        private TextBox txtApellido;
        private Button btnInsertar;
        private Button btnUpdate;
    }
}
