namespace NetCoreAdoNet
{
    partial class Form03EliminarEnfermo
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
            btEliminar = new Button();
            txtInscripcion = new TextBox();
            lstEnfermos = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 50);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Inscripción";
            // 
            // btEliminar
            // 
            btEliminar.Location = new Point(59, 129);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(100, 42);
            btEliminar.TabIndex = 1;
            btEliminar.Text = "Eliminar Enfermo";
            btEliminar.UseVisualStyleBackColor = true;
            btEliminar.Click += btEliminar_Click;
            // 
            // txtInscripcion
            // 
            txtInscripcion.Location = new Point(59, 77);
            txtInscripcion.Name = "txtInscripcion";
            txtInscripcion.Size = new Size(100, 23);
            txtInscripcion.TabIndex = 2;
            // 
            // lstEnfermos
            // 
            lstEnfermos.FormattingEnabled = true;
            lstEnfermos.Location = new Point(269, 77);
            lstEnfermos.Name = "lstEnfermos";
            lstEnfermos.Size = new Size(266, 199);
            lstEnfermos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 50);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Enfermos";
            // 
            // Form03EliminarEnfermo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lstEnfermos);
            Controls.Add(txtInscripcion);
            Controls.Add(btEliminar);
            Controls.Add(label1);
            Name = "Form03EliminarEnfermo";
            Text = "Form03EliminarEnfermo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btEliminar;
        private TextBox txtInscripcion;
        private ListBox lstEnfermos;
        private Label label2;
    }
}