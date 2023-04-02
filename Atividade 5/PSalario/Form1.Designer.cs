namespace PSalario
{
    partial class Form1
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
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblSalBrt = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.mskbxSalBrt = new System.Windows.Forms.MaskedTextBox();
            this.nudFilhos = new System.Windows.Forms.NumericUpDown();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.cbxCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDscINSS = new System.Windows.Forms.Label();
            this.lblDscIRPF = new System.Windows.Forms.Label();
            this.txtAlqINSS = new System.Windows.Forms.TextBox();
            this.txtAlqIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFamilia = new System.Windows.Forms.TextBox();
            this.txtDscINSS = new System.Windows.Forms.TextBox();
            this.txtDscIRPF = new System.Windows.Forms.TextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).BeginInit();
            this.gbxSexo.SuspendLayout();
            this.cbxCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.Location = new System.Drawing.Point(30, 50);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(129, 16);
            this.lblFunc.TabIndex = 0;
            this.lblFunc.Text = "Nome funcionário";
            // 
            // lblSalBrt
            // 
            this.lblSalBrt.AutoSize = true;
            this.lblSalBrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalBrt.Location = new System.Drawing.Point(30, 95);
            this.lblSalBrt.Name = "lblSalBrt";
            this.lblSalBrt.Size = new System.Drawing.Size(97, 16);
            this.lblSalBrt.TabIndex = 1;
            this.lblSalBrt.Text = "Salário bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilhos.Location = new System.Drawing.Point(30, 142);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(88, 16);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Nº de filhos";
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(185, 50);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(236, 20);
            this.txtFunc.TabIndex = 3;
            this.txtFunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFunc_KeyPress);
            // 
            // mskbxSalBrt
            // 
            this.mskbxSalBrt.Location = new System.Drawing.Point(185, 95);
            this.mskbxSalBrt.Mask = "0000999.99";
            this.mskbxSalBrt.Name = "mskbxSalBrt";
            this.mskbxSalBrt.Size = new System.Drawing.Size(236, 20);
            this.mskbxSalBrt.TabIndex = 4;
            // 
            // nudFilhos
            // 
            this.nudFilhos.Location = new System.Drawing.Point(185, 138);
            this.nudFilhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFilhos.Name = "nudFilhos";
            this.nudFilhos.Size = new System.Drawing.Size(120, 20);
            this.nudFilhos.TabIndex = 5;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(185, 188);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(213, 23);
            this.btnDesconto.TabIndex = 6;
            this.btnDesconto.Text = "Verificar desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.BtnDesconto_Click);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSexo.Location = new System.Drawing.Point(545, 34);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(246, 177);
            this.gbxSexo.TabIndex = 7;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(56, 90);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(96, 20);
            this.rbtnMasc.TabIndex = 1;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "Masculino";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(56, 51);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(89, 20);
            this.rbtnFem.TabIndex = 0;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "Feminino";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // cbxCasado
            // 
            this.cbxCasado.Controls.Add(this.ckbxCasado);
            this.cbxCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCasado.Location = new System.Drawing.Point(545, 250);
            this.cbxCasado.Name = "cbxCasado";
            this.cbxCasado.Size = new System.Drawing.Size(246, 113);
            this.cbxCasado.TabIndex = 8;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxCasado.Location = new System.Drawing.Point(56, 53);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(83, 17);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado(a)";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aliquota INSS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aliquota IRPF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Salário Familia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Salário Liquido";
            // 
            // lblDscINSS
            // 
            this.lblDscINSS.AutoSize = true;
            this.lblDscINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDscINSS.Location = new System.Drawing.Point(510, 393);
            this.lblDscINSS.Name = "lblDscINSS";
            this.lblDscINSS.Size = new System.Drawing.Size(113, 16);
            this.lblDscINSS.TabIndex = 13;
            this.lblDscINSS.Text = "Desconto INSS";
            // 
            // lblDscIRPF
            // 
            this.lblDscIRPF.AutoSize = true;
            this.lblDscIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDscIRPF.Location = new System.Drawing.Point(511, 441);
            this.lblDscIRPF.Name = "lblDscIRPF";
            this.lblDscIRPF.Size = new System.Drawing.Size(112, 16);
            this.lblDscIRPF.TabIndex = 14;
            this.lblDscIRPF.Text = "Desconto IRPF";
            // 
            // txtAlqINSS
            // 
            this.txtAlqINSS.Enabled = false;
            this.txtAlqINSS.Location = new System.Drawing.Point(149, 267);
            this.txtAlqINSS.Name = "txtAlqINSS";
            this.txtAlqINSS.ReadOnly = true;
            this.txtAlqINSS.Size = new System.Drawing.Size(100, 20);
            this.txtAlqINSS.TabIndex = 15;
            // 
            // txtAlqIRPF
            // 
            this.txtAlqIRPF.Enabled = false;
            this.txtAlqIRPF.Location = new System.Drawing.Point(149, 307);
            this.txtAlqIRPF.Name = "txtAlqIRPF";
            this.txtAlqIRPF.ReadOnly = true;
            this.txtAlqIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtAlqIRPF.TabIndex = 16;
            // 
            // txtSalFamilia
            // 
            this.txtSalFamilia.Enabled = false;
            this.txtSalFamilia.Location = new System.Drawing.Point(149, 347);
            this.txtSalFamilia.Name = "txtSalFamilia";
            this.txtSalFamilia.ReadOnly = true;
            this.txtSalFamilia.Size = new System.Drawing.Size(100, 20);
            this.txtSalFamilia.TabIndex = 17;
            // 
            // txtDscINSS
            // 
            this.txtDscINSS.Enabled = false;
            this.txtDscINSS.Location = new System.Drawing.Point(629, 393);
            this.txtDscINSS.Name = "txtDscINSS";
            this.txtDscINSS.ReadOnly = true;
            this.txtDscINSS.Size = new System.Drawing.Size(100, 20);
            this.txtDscINSS.TabIndex = 19;
            // 
            // txtDscIRPF
            // 
            this.txtDscIRPF.Enabled = false;
            this.txtDscIRPF.Location = new System.Drawing.Point(629, 441);
            this.txtDscIRPF.Name = "txtDscIRPF";
            this.txtDscIRPF.ReadOnly = true;
            this.txtDscIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtDscIRPF.TabIndex = 20;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(30, 222);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(48, 13);
            this.lblDados.TabIndex = 21;
            this.lblDados.Text = "lblDados";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(149, 389);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioLiquido.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 579);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtDscIRPF);
            this.Controls.Add(this.txtDscINSS);
            this.Controls.Add(this.txtSalFamilia);
            this.Controls.Add(this.txtAlqIRPF);
            this.Controls.Add(this.txtAlqINSS);
            this.Controls.Add(this.lblDscIRPF);
            this.Controls.Add(this.lblDscINSS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCasado);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.nudFilhos);
            this.Controls.Add(this.mskbxSalBrt);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalBrt);
            this.Controls.Add(this.lblFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFilhos)).EndInit();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.cbxCasado.ResumeLayout(false);
            this.cbxCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label lblSalBrt;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.MaskedTextBox mskbxSalBrt;
        private System.Windows.Forms.NumericUpDown nudFilhos;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.Panel cbxCasado;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDscINSS;
        private System.Windows.Forms.Label lblDscIRPF;
        private System.Windows.Forms.TextBox txtAlqINSS;
        private System.Windows.Forms.TextBox txtAlqIRPF;
        private System.Windows.Forms.TextBox txtSalFamilia;
        private System.Windows.Forms.TextBox txtDscINSS;
        private System.Windows.Forms.TextBox txtDscIRPF;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.TextBox txtSalarioLiquido;



    }
}

