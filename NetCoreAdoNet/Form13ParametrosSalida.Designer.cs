namespace NetCoreAdoNet
{
    partial class Form13ParametrosSalida
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
            cbDepartamentos = new ComboBox();
            lstEmpleados = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtSuma = new TextBox();
            txtPersonas = new TextBox();
            label4 = new Label();
            txtMedia = new TextBox();
            label5 = new Label();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 73);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // cbDepartamentos
            // 
            cbDepartamentos.FormattingEnabled = true;
            cbDepartamentos.Location = new Point(45, 102);
            cbDepartamentos.Name = "cbDepartamentos";
            cbDepartamentos.Size = new Size(178, 23);
            cbDepartamentos.TabIndex = 1;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(322, 87);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(226, 319);
            lstEmpleados.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 57);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 196);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 4;
            label3.Text = "Suma Salarial";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(45, 226);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 5;
            // 
            // txtPersonas
            // 
            txtPersonas.Location = new Point(45, 375);
            txtPersonas.Name = "txtPersonas";
            txtPersonas.Size = new Size(100, 23);
            txtPersonas.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 345);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 6;
            label4.Text = "Personas";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(45, 304);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(100, 23);
            txtMedia.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 274);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 8;
            label5.Text = "Media Salarial";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(45, 140);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(178, 34);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form13ParametrosSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(txtMedia);
            Controls.Add(label5);
            Controls.Add(txtPersonas);
            Controls.Add(label4);
            Controls.Add(txtSuma);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstEmpleados);
            Controls.Add(cbDepartamentos);
            Controls.Add(label1);
            Name = "Form13ParametrosSalida";
            Text = "Form13ParametrosSalida";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbDepartamentos;
        private ListBox lstEmpleados;
        private Label label2;
        private Label label3;
        private TextBox txtSuma;
        private TextBox txtPersonas;
        private Label label4;
        private TextBox txtMedia;
        private Label label5;
        private Button btnMostrar;
    }
}