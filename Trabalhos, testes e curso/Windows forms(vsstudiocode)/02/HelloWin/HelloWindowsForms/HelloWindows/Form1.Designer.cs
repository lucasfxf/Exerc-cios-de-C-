namespace HelloWindows
{
    partial class Form1
    {
               private System.ComponentModel.IContainer components = null;

      
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

     
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
          
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(250, 68);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA IMC";
           
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 211);
            label2.Name = "label2";
            label2.Size = new Size(128, 37);
            label2.TabIndex = 1;
            label2.Text = "ALTURA:";
          
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 155);
            label3.Name = "label3";
            label3.Size = new Size(90, 37);
            label3.TabIndex = 2;
            label3.Text = "PESO:";
          
            txtPeso.Font = new Font("Segoe UI", 18F);
            txtPeso.Location = new Point(345, 155);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(133, 39);
            txtPeso.TabIndex = 3;
          
            txtAltura.Font = new Font("Segoe UI", 18F);
            txtAltura.Location = new Point(345, 209);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(133, 39);
            txtAltura.TabIndex = 4;
         
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.Blue;
            btnCalcular.Location = new Point(297, 275);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 43);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
          
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(273, 369);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(152, 37);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado:";
          
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 502);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
