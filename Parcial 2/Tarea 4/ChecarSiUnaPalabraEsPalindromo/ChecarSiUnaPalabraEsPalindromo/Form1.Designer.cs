namespace ChecarSiUnaPalabraEsPalindromo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btnRevisar = new Button();
            lblVerificacion = new Label();
            lblCadena = new Label();
            txtCadena = new TextBox();
            SuspendLayout();
            // 
            // btnRevisar
            // 
            btnRevisar.Location = new Point(95, 100);
            btnRevisar.Name = "btnRevisar";
            btnRevisar.Size = new Size(187, 23);
            btnRevisar.TabIndex = 13;
            btnRevisar.Text = "Revisar si es palindromo";
            btnRevisar.UseVisualStyleBackColor = true;
            btnRevisar.Click += btnRevisar_Click;
            // 
            // lblVerificacion
            // 
            lblVerificacion.ForeColor = Color.Blue;
            lblVerificacion.Location = new Point(17, 126);
            lblVerificacion.Name = "lblVerificacion";
            lblVerificacion.Size = new Size(350, 27);
            lblVerificacion.TabIndex = 12;
            lblVerificacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCadena
            // 
            lblCadena.AutoSize = true;
            lblCadena.Location = new Point(12, 32);
            lblCadena.Name = "lblCadena";
            lblCadena.Size = new Size(50, 15);
            lblCadena.TabIndex = 11;
            lblCadena.Text = "Cadena:";
            // 
            // txtCadena
            // 
            txtCadena.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCadena.Location = new Point(12, 55);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(350, 29);
            txtCadena.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 165);
            Controls.Add(btnRevisar);
            Controls.Add(lblVerificacion);
            Controls.Add(lblCadena);
            Controls.Add(txtCadena);
            Name = "Form1";
            Text = "Programa2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRevisar;
        private Label lblVerificacion;
        private Label lblCadena;
        private TextBox txtCadena;
    }
}
