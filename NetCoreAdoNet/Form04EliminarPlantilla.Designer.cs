namespace NetCoreAdoNet
{
    partial class Form04EliminarPlantilla
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
            lstPlantilla = new ListBox();
            txtInscripcion = new TextBox();
            btnPlantilla = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 35);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 9;
            label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            lstPlantilla.FormattingEnabled = true;
            lstPlantilla.Location = new Point(239, 62);
            lstPlantilla.Name = "lstPlantilla";
            lstPlantilla.Size = new Size(266, 199);
            lstPlantilla.TabIndex = 8;
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(29, 62);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(100, 23);
            txtInscripcion.TabIndex = 7;
            // 
            // btnPlantilla
            // 
            btnPlantilla.Location = new Point(29, 114);
            btnPlantilla.Name = "btnPlantilla";
            btnPlantilla.Size = new Size(100, 42);
            btnPlantilla.TabIndex = 6;
            btnPlantilla.Text = "Eliminar Plantilla";
            btnPlantilla.UseVisualStyleBackColor = true;
            btnPlantilla.Click += btnPlantilla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 35);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 5;
            label1.Text = "Inscripción";
            // 
            // Form04EliminarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lstPlantilla);
            Controls.Add(txtInscripcion);
            Controls.Add(btnPlantilla);
            Controls.Add(label1);
            Name = "Form04EliminarPlantilla";
            Text = "Form04EliminarPlantilla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lstPlantilla;
        private TextBox txtInscripcion;
        private Button btnPlantilla;
        private Label label1;
    }
}