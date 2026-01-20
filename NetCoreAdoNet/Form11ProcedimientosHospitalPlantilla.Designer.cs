namespace NetCoreAdoNet
{
    partial class Form11ProcedimientosHospitalPlantilla
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
            btnSalario = new Button();
            txtIncremento = new TextBox();
            lstPlantilla = new ListBox();
            cbHosp = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 43);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Hospitales";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 43);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Incremento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 188);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Plantilla";
            // 
            // btnSalario
            // 
            btnSalario.Location = new Point(156, 112);
            btnSalario.Name = "btnSalario";
            btnSalario.Size = new Size(147, 32);
            btnSalario.TabIndex = 3;
            btnSalario.Text = "Modificar Salarios";
            btnSalario.UseVisualStyleBackColor = true;
            btnSalario.Click += btnSalario_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(265, 71);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 5;
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(58, 224);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(307, 124);
            lstPlantilla.TabIndex = 6;
            // 
            // cbHosp
            // 
            cbHosp.FormattingEnabled = true;
            cbHosp.Location = new Point(58, 71);
            cbHosp.Name = "cbHosp";
            cbHosp.Size = new Size(121, 23);
            cbHosp.TabIndex = 7;
            cbHosp.SelectedIndexChanged += cbHosp_SelectedIndexChanged;
            // 
            // Form11ProcedimientosHospitalPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbHosp);
            Controls.Add(lstPlantilla);
            Controls.Add(txtIncremento);
            Controls.Add(btnSalario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form11ProcedimientosHospitalPlantilla";
            Text = "Form11ProcedimientosHospitalPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalario;
        private TextBox txtIncremento;
        private ListBox lstPlantilla;
        private ComboBox cbHosp;
    }
}