namespace NetCoreAdoNet
{
    partial class Form05UpdateSalas
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
            label2.Location = new Point(250, 22);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 14;
            label2.Text = "Salas";
            // 
            // lstSalas
            // 
            lstSalas.FormattingEnabled = true;
            lstSalas.Location = new Point(250, 49);
            lstSalas.Name = "lstSalas";
            lstSalas.Size = new Size(266, 199);
            lstSalas.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(40, 101);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 42);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update Salas";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 10;
            label1.Text = "Nuevo Nombre";
            // 
            // Form05UpdateSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lstSalas);
            Controls.Add(txtNombre);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Name = "Form05UpdateSalas";
            Text = "Form05UpdateSalas";
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