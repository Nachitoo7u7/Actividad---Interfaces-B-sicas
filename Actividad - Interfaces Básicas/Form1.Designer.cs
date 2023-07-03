namespace Actividad___Interfaces_Básicas
{
    partial class Calculator
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblResu1 = new System.Windows.Forms.Label();
            this.lblResu2 = new System.Windows.Forms.Label();
            this.lblResu3 = new System.Windows.Forms.Label();
            this.lblResu4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.ForeColor = System.Drawing.Color.Silver;
            this.txtNum1.Location = new System.Drawing.Point(12, 48);
            this.txtNum1.Multiline = true;
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(210, 21);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.Text = "Ingrese el primer número";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.Enter += new System.EventHandler(this.txtNum1_Enter);
            this.txtNum1.Leave += new System.EventHandler(this.txtNum1_Leave);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(266, 59);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 44);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.ForeColor = System.Drawing.Color.Silver;
            this.txtNum2.Location = new System.Drawing.Point(12, 82);
            this.txtNum2.Multiline = true;
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(210, 21);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.Text = "Ingrese el segundo número";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.Enter += new System.EventHandler(this.txtNum2_Enter);
            this.txtNum2.Leave += new System.EventHandler(this.txtNum2_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 32);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(359, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resultados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Multiplicación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "División:";
            // 
            // lblResu1
            // 
            this.lblResu1.BackColor = System.Drawing.Color.LightGray;
            this.lblResu1.Location = new System.Drawing.Point(146, 182);
            this.lblResu1.Name = "lblResu1";
            this.lblResu1.Size = new System.Drawing.Size(162, 23);
            this.lblResu1.TabIndex = 10;
            // 
            // lblResu2
            // 
            this.lblResu2.BackColor = System.Drawing.Color.LightGray;
            this.lblResu2.Location = new System.Drawing.Point(146, 227);
            this.lblResu2.Name = "lblResu2";
            this.lblResu2.Size = new System.Drawing.Size(162, 23);
            this.lblResu2.TabIndex = 11;
            // 
            // lblResu3
            // 
            this.lblResu3.BackColor = System.Drawing.Color.LightGray;
            this.lblResu3.Location = new System.Drawing.Point(146, 271);
            this.lblResu3.Name = "lblResu3";
            this.lblResu3.Size = new System.Drawing.Size(162, 23);
            this.lblResu3.TabIndex = 12;
            // 
            // lblResu4
            // 
            this.lblResu4.BackColor = System.Drawing.Color.LightGray;
            this.lblResu4.Location = new System.Drawing.Point(146, 312);
            this.lblResu4.Name = "lblResu4";
            this.lblResu4.Size = new System.Drawing.Size(162, 23);
            this.lblResu4.TabIndex = 13;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 375);
            this.Controls.Add(this.lblResu4);
            this.Controls.Add(this.lblResu3);
            this.Controls.Add(this.lblResu2);
            this.Controls.Add(this.lblResu1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResu1;
        private System.Windows.Forms.Label lblResu2;
        private System.Windows.Forms.Label lblResu3;
        private System.Windows.Forms.Label lblResu4;
    }
}

