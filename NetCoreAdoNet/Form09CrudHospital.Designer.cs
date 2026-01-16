namespace NetCoreAdoNet
{
    partial class Form09CrudHospital
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
            lstHospitales = new ListBox();
            btnBuscar = new Button();
            btnEdit = new Button();
            btnBorrar = new Button();
            btnInsertar = new Button();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDir = new TextBox();
            txtTel = new TextBox();
            txtCamas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lstHospitales
            // 
            lstHospitales.FormattingEnabled = true;
            lstHospitales.Location = new Point(147, 213);
            lstHospitales.Name = "lstHospitales";
            lstHospitales.Size = new Size(507, 154);
            lstHospitales.TabIndex = 0;
            lstHospitales.SelectedIndexChanged += lstHospitales_SelectedIndexChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(436, 395);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Mostrar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(249, 395);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(147, 395);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 3;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(501, 158);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(155, 67);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(350, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(542, 66);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(100, 23);
            txtDir.TabIndex = 7;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(155, 150);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(100, 23);
            txtTel.TabIndex = 8;
            // 
            // txtCamas
            // 
            txtCamas.Location = new Point(342, 153);
            txtCamas.Name = "txtCamas";
            txtCamas.Size = new Size(100, 23);
            txtCamas.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 36);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 29);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 27);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 12;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 110);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 13;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 122);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 14;
            label5.Text = "Nº Camas";
            // 
            // Form09CrudHospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCamas);
            Controls.Add(txtTel);
            Controls.Add(txtDir);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(btnInsertar);
            Controls.Add(btnBorrar);
            Controls.Add(btnEdit);
            Controls.Add(btnBuscar);
            Controls.Add(lstHospitales);
            Name = "Form09CrudHospital";
            Text = "Form09CrudHospital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstHospitales;
        private Button btnBuscar;
        private Button btnEdit;
        private Button btnBorrar;
        private Button btnInsertar;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDir;
        private TextBox txtTel;
        private TextBox txtCamas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}