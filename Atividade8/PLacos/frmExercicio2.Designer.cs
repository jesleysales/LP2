namespace PLacos
{
    partial class frmExercicio2
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
            this.btnGerarNumeroH = new System.Windows.Forms.Button();
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGerarNumeroH
            // 
            this.btnGerarNumeroH.Location = new System.Drawing.Point(274, 193);
            this.btnGerarNumeroH.Name = "btnGerarNumeroH";
            this.btnGerarNumeroH.Size = new System.Drawing.Size(147, 76);
            this.btnGerarNumeroH.TabIndex = 0;
            this.btnGerarNumeroH.Text = "Gerar número H";
            this.btnGerarNumeroH.UseVisualStyleBackColor = true;
            this.btnGerarNumeroH.Click += new System.EventHandler(this.BtnGerarNumeroH_Click);
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(246, 139);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(212, 20);
            this.txtNumeroN.TabIndex = 1;
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNumeroN);
            this.Controls.Add(this.btnGerarNumeroH);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarNumeroH;
        private System.Windows.Forms.TextBox txtNumeroN;
    }
}