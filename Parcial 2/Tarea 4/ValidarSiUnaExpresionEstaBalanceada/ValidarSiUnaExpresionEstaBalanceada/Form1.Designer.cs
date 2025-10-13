namespace ValidarSiUnaExpresionEstaBalanceada
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtExpresion = new TextBox();
            lblExpresion = new Label();
            lblValidacion = new Label();
            btnValidar = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // txtExpresion
            // 
            txtExpresion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpresion.Location = new Point(33, 77);
            txtExpresion.Name = "txtExpresion";
            txtExpresion.Size = new Size(350, 29);
            txtExpresion.TabIndex = 0;
            txtExpresion.TextChanged += txtExpresion_TextChanged;
            // 
            // lblExpresion
            // 
            lblExpresion.AutoSize = true;
            lblExpresion.Location = new Point(33, 54);
            lblExpresion.Name = "lblExpresion";
            lblExpresion.Size = new Size(60, 15);
            lblExpresion.TabIndex = 1;
            lblExpresion.Text = "Expresion:";
            // 
            // lblValidacion
            // 
            lblValidacion.AutoSize = true;
            lblValidacion.ForeColor = Color.Red;
            lblValidacion.Location = new Point(212, 115);
            lblValidacion.Name = "lblValidacion";
            lblValidacion.Size = new Size(0, 15);
            lblValidacion.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(33, 127);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(33, 12);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Validacion automatica";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 196);
            Controls.Add(checkBox1);
            Controls.Add(btnValidar);
            Controls.Add(lblValidacion);
            Controls.Add(lblExpresion);
            Controls.Add(txtExpresion);
            Name = "Form1";
            Text = "Programa1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpresion;
        private Label lblExpresion;
        private Label lblValidacion;
        private Button btnValidar;
        private CheckBox checkBox1;
    }
}
