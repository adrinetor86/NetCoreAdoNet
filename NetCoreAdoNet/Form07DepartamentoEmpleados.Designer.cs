namespace NetCoreAdoNet
{
    partial class Form07DepartamentoEmpleados
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
            label2 = new Label();
            lstDepartamentos = new ListBox();
            label1 = new Label();
            lstEmpleados = new ListBox();
            label3 = new Label();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 24);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 21;
            label2.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(42, 51);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(136, 199);
            lstDepartamentos.TabIndex = 20;
            lstDepartamentos.SelectedIndexChanged += lstDepartamentos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 23;
            label1.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(369, 51);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(146, 199);
            lstEmpleados.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(639, 46);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 24;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(613, 121);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form07DepartamentoEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(lstDepartamentos);
            Name = "Form07DepartamentoEmpleados";
            Text = "Form07DepartamentoEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lstDepartamentos;
        private Label label1;
        private ListBox lstEmpleados;
        private Label label3;
        private Button btnEliminar;
    }
}