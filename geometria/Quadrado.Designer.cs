namespace geometria
{
    partial class Quadrado
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbL1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbL2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado 1";
            // 
            // tbL1
            // 
            this.tbL1.Location = new System.Drawing.Point(8, 8);
            this.tbL1.Name = "tbL1";
            this.tbL1.Size = new System.Drawing.Size(100, 20);
            this.tbL1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "lado 2";
            // 
            // tbL2
            // 
            this.tbL2.Location = new System.Drawing.Point(24, 24);
            this.tbL2.Name = "tbL2";
            this.tbL2.Size = new System.Drawing.Size(100, 20);
            this.tbL2.TabIndex = 3;
            this.tbL2.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(40, 40);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(50, 13);
            this.resultado.TabIndex = 5;
            this.resultado.Text = "resultado";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(48, 48);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 20);
            this.tbResult.TabIndex = 6;
            // 
            // Quadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbL2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbL1);
            this.Controls.Add(this.label1);
            this.Name = "Quadrado";
            this.Text = "Calcula área de um quadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbL2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox tbResult;
    }
}