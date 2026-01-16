namespace NetCoreAdoNet
{
    partial class Form08CrudDepartamentos
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
            btnInsert = new Button();
            btnUpdate = new Button();
            btnEliminar = new Button();
            lstDepartamentos = new ListBox();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtLocalidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 59);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Departamentos";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(273, 333);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(91, 35);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(273, 378);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(91, 31);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(75, 320);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(114, 48);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lstDepartamentos
            // 
            lstDepartamentos.FormattingEnabled = true;
            lstDepartamentos.Location = new Point(39, 89);
            lstDepartamentos.Name = "lstDepartamentos";
            lstDepartamentos.Size = new Size(190, 214);
            lstDepartamentos.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(273, 115);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(273, 206);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(273, 288);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(100, 23);
            txtLocalidad.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 89);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 9;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 167);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(273, 258);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 11;
            label4.Text = "Localidad";
            // 
            // Form08CrudDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtLocalidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lstDepartamentos);
            Controls.Add(btnEliminar);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(label1);
            Name = "Form08CrudDepartamentos";
            Text = "Form07CrudDepartamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnEliminar;
        private ListBox lstDepartamentos;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtLocalidad;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}