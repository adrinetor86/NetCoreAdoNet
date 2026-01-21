namespace NetCoreAdoNet
{
    partial class Form10UpdateEmpleadosOficio
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
            label3 = new Label();
            label4 = new Label();
            btnIncremento = new Button();
            lblSumaSalarial = new Label();
            lblMedia = new Label();
            lblMax = new Label();
            lstOficios = new ListBox();
            lstEmpleados = new ListBox();
            txtSubida = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 30);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 95);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 226);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(640, 130);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(75, 23);
            btnIncremento.TabIndex = 4;
            btnIncremento.Text = "Subida Salario";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // lblSumaSalarial
            // 
            lblSumaSalarial.AutoSize = true;
            lblSumaSalarial.Location = new Point(95, 317);
            lblSumaSalarial.Name = "lblSumaSalarial";
            lblSumaSalarial.Size = new Size(38, 15);
            lblSumaSalarial.TabIndex = 5;
            lblSumaSalarial.Text = "label5";
            // 
            // lblMedia
            // 
            lblMedia.AutoSize = true;
            lblMedia.Location = new Point(95, 347);
            lblMedia.Name = "lblMedia";
            lblMedia.Size = new Size(38, 15);
            lblMedia.TabIndex = 6;
            lblMedia.Text = "label6";
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.Location = new Point(95, 381);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(38, 15);
            lblMax.TabIndex = 7;
            lblMax.Text = "label7";
            // 
            // lstOficios
            // 
            lstOficios.FormattingEnabled = true;
            lstOficios.Location = new Point(38, 73);
            lstOficios.Name = "lstOficios";
            lstOficios.Size = new Size(120, 229);
            lstOficios.TabIndex = 8;
            lstOficios.SelectedIndexChanged += lstOficios_SelectedIndexChanged;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.Location = new Point(257, 73);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(120, 229);
            lstEmpleados.TabIndex = 9;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // txtSubida
            // 
            txtSubida.Location = new Point(630, 92);
            txtSubida.Name = "txtSubida";
            txtSubida.Size = new Size(100, 23);
            txtSubida.TabIndex = 10;
            // 
            // Form10UpdateEmpleadosOficio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSubida);
            Controls.Add(lstEmpleados);
            Controls.Add(lstOficios);
            Controls.Add(lblMax);
            Controls.Add(lblMedia);
            Controls.Add(lblSumaSalarial);
            Controls.Add(btnIncremento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10UpdateEmpleadosOficio";
            Text = "Form10UpdateEmpleadosOficio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnIncremento;
        private Label lblSumaSalarial;
        private Label lblMedia;
        private Label lblMax;
        private ListBox lstOficios;
        private ListBox lstEmpleados;
        private TextBox txtSubida;
    }
}