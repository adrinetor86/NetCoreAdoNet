namespace NetCoreAdoNet
{
    partial class Form01PrimerAdo
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
            btnConec = new Button();
            btnDesc = new Button();
            btnRead = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstApellidos = new ListBox();
            lstColumnas = new ListBox();
            lstTipos = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnConec
            // 
            btnConec.Location = new Point(44, 98);
            btnConec.Name = "btnConec";
            btnConec.Size = new Size(75, 23);
            btnConec.TabIndex = 0;
            btnConec.Text = "Conectar";
            btnConec.UseVisualStyleBackColor = true;
            btnConec.Click += btnConec_Click;
            // 
            // btnDesc
            // 
            btnDesc.Location = new Point(44, 153);
            btnDesc.Name = "btnDesc";
            btnDesc.Size = new Size(75, 23);
            btnDesc.TabIndex = 1;
            btnDesc.Text = "Desconectar";
            btnDesc.UseVisualStyleBackColor = true;
            btnDesc.Click += btnDesc_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(44, 211);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 72);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Apellidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(469, 72);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Tipos dato";
            // 
            // lstApellidos
            // 
            lstApellidos.FormattingEnabled = true;
            lstApellidos.Location = new Point(169, 106);
            lstApellidos.Name = "lstApellidos";
            lstApellidos.Size = new Size(120, 169);
            lstApellidos.TabIndex = 6;
            // 
            // lstColumnas
            // 
            lstColumnas.FormattingEnabled = true;
            lstColumnas.Location = new Point(320, 106);
            lstColumnas.Name = "lstColumnas";
            lstColumnas.Size = new Size(120, 169);
            lstColumnas.TabIndex = 7;
            // 
            // lstTipos
            // 
            lstTipos.FormattingEnabled = true;
            lstTipos.Location = new Point(469, 106);
            lstTipos.Name = "lstTipos";
            lstTipos.Size = new Size(120, 169);
            lstTipos.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 305);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 9;
            label4.Text = "lblConexion";
            // 
            // Form01PrimerAdo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(lstTipos);
            Controls.Add(lstColumnas);
            Controls.Add(lstApellidos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Controls.Add(btnDesc);
            Controls.Add(btnConec);
            Name = "Form01PrimerAdo";
            Text = "Form01PrimerAdo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConec;
        private Button btnDesc;
        private Button btnRead;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstApellidos;
        private ListBox lstColumnas;
        private ListBox lstTipos;
        private Label label4;
    }
}