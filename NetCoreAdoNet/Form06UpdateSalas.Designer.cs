namespace NetCoreAdoNet
{
    partial class Form06UpdateSalas
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
            lstSalas = new ListBox();
            txtNombre = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(243, 34);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 19;
            label2.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(243, 61);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(266, 199);
            lstSalas.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(33, 113);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 42);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Salas";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 34);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 15;
            label1.Text = "Nuevo Nombre";
            // 
            // Form06UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(txtNombre);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Name = "Form06UpdateSalas";
            Text = "Form06UpdateSalas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lstSalas;
        private TextBox txtNombre;
        private Button btnUpdate;
        private Label label1;
    }
}