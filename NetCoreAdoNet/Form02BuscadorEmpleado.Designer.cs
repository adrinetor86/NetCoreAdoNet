namespace NetCoreAdoNet
{
    partial class Form02BuscadorEmpleado
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
            txtEmpleado = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            lstEmpleados = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 65);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtEmpleado
            // 
            txtEmpleado.Location = new Point(54, 94);
            txtEmpleado.Name = "txtEmpleado";
            txtEmpleado.Size = new Size(193, 23);
            txtEmpleado.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(63, 150);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(152, 33);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "button1";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 226);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(54, 253);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(120, 94);
            lstEmpleados.TabIndex = 4;
            // 
            // Form02BuscadorEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstEmpleados);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtEmpleado);
            Controls.Add(label1);
            Name = "Form02BuscadorEmpleado";
            Text = "Form02BuscadorEmpleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmpleado;
        private Button btnBuscar;
        private Label label2;
        private ListBox lstEmpleados;
    }
}