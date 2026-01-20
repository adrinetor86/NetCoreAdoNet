namespace NetCoreAdoNet
{
    partial class Form14Settings
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
            btnLeer = new Button();
            lblConexion = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnHelper = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(34, 56);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(211, 48);
            btnLeer.TabIndex = 0;
            btnLeer.Text = "Leer Settings";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // lblConexion
            // 
            lblConexion.AutoSize = true;
            lblConexion.Location = new Point(34, 153);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(92, 21);
            lblConexion.TabIndex = 1;
            lblConexion.Text = "lblConexion";
            lblConexion.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(252, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(366, 221);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 227);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btnHelper
            // 
            btnHelper.Location = new Point(366, 49);
            btnHelper.Name = "btnHelper";
            btnHelper.Size = new Size(186, 63);
            btnHelper.TabIndex = 4;
            btnHelper.Text = "Leer Helper Configuration";
            btnHelper.UseVisualStyleBackColor = true;
            btnHelper.Click += btnHelper_Click;
            // 
            // Form14Settings
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 478);
            Controls.Add(btnHelper);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblConexion);
            Controls.Add(btnLeer);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form14Settings";
            Text = "Form14Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeer;
        private Label lblConexion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnHelper;
    }
}