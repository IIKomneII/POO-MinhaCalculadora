namespace MinhaCalculadora
{
    partial class MinhaCalculadora
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
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            cmbFunções = new ComboBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(126, 175);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 27);
            txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(524, 175);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 1;
            // 
            // cmbFunções
            // 
            cmbFunções.FormattingEnabled = true;
            cmbFunções.Items.AddRange(new object[] { "+", "-", "x", "/" });
            cmbFunções.Location = new Point(317, 175);
            cmbFunções.Name = "cmbFunções";
            cmbFunções.Size = new Size(151, 28);
            cmbFunções.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(192, 255, 192);
            btnCalcular.Location = new Point(317, 311);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 44);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(362, 254);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(13, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = " ";
            // 
            // MinhaCalculadora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(cmbFunções);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Name = "MinhaCalculadora";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private ComboBox cmbFunções;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
