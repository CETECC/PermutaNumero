namespace WindowsFormsApplication2
{
    partial class PermutaNumero
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroA = new System.Windows.Forms.TextBox();
            this.txtNumeroB = new System.Windows.Forms.TextBox();
            this.verificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NumeroA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NumeroB";
            // 
            // txtNumeroA
            // 
            this.txtNumeroA.Location = new System.Drawing.Point(85, 32);
            this.txtNumeroA.Name = "txtNumeroA";
            this.txtNumeroA.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroA.TabIndex = 2;
            // 
            // txtNumeroB
            // 
            this.txtNumeroB.Location = new System.Drawing.Point(85, 73);
            this.txtNumeroB.Name = "txtNumeroB";
            this.txtNumeroB.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroB.TabIndex = 3;
            // 
            // verificar
            // 
            this.verificar.Location = new System.Drawing.Point(85, 115);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(75, 23);
            this.verificar.TabIndex = 4;
            this.verificar.Text = "verificar";
            this.verificar.UseVisualStyleBackColor = true;
            this.verificar.Click += new System.EventHandler(this.verificar_Click);
            // 
            // PermutaNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 170);
            this.Controls.Add(this.verificar);
            this.Controls.Add(this.txtNumeroB);
            this.Controls.Add(this.txtNumeroA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PermutaNumero";
            this.Text = "Permuta Número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroA;
        private System.Windows.Forms.TextBox txtNumeroB;
        private System.Windows.Forms.Button verificar;
    }
}

