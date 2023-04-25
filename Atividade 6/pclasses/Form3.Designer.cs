namespace pclasses
{
    partial class frmHorista
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
            this.lblMatricula2 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblSalHora = new System.Windows.Forms.Label();
            this.lblDataEntEmp2 = new System.Windows.Forms.Label();
            this.lblFaltas = new System.Windows.Forms.Label();
            this.txtMatricula2 = new System.Windows.Forms.TextBox();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.txtSalHora = new System.Windows.Forms.TextBox();
            this.txtDataEntEmp2 = new System.Windows.Forms.TextBox();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.btnInstanciarH = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSim2 = new System.Windows.Forms.RadioButton();
            this.rbtnNao2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula2
            // 
            this.lblMatricula2.AutoSize = true;
            this.lblMatricula2.Location = new System.Drawing.Point(58, 74);
            this.lblMatricula2.Name = "lblMatricula2";
            this.lblMatricula2.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula2.TabIndex = 0;
            this.lblMatricula2.Text = "Matricula";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(58, 118);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(35, 13);
            this.lblNome2.TabIndex = 1;
            this.lblNome2.Text = "Nome";
            // 
            // lblSalHora
            // 
            this.lblSalHora.AutoSize = true;
            this.lblSalHora.Location = new System.Drawing.Point(58, 157);
            this.lblSalHora.Name = "lblSalHora";
            this.lblSalHora.Size = new System.Drawing.Size(83, 13);
            this.lblSalHora.TabIndex = 2;
            this.lblSalHora.Text = "Salario por Hora";
            // 
            // lblDataEntEmp2
            // 
            this.lblDataEntEmp2.AutoSize = true;
            this.lblDataEntEmp2.Location = new System.Drawing.Point(58, 195);
            this.lblDataEntEmp2.Name = "lblDataEntEmp2";
            this.lblDataEntEmp2.Size = new System.Drawing.Size(129, 13);
            this.lblDataEntEmp2.TabIndex = 3;
            this.lblDataEntEmp2.Text = "Data Entrada na Empresa";
            // 
            // lblFaltas
            // 
            this.lblFaltas.AutoSize = true;
            this.lblFaltas.Location = new System.Drawing.Point(58, 238);
            this.lblFaltas.Name = "lblFaltas";
            this.lblFaltas.Size = new System.Drawing.Size(74, 13);
            this.lblFaltas.TabIndex = 4;
            this.lblFaltas.Text = "Dias de Faltas";
            // 
            // txtMatricula2
            // 
            this.txtMatricula2.Location = new System.Drawing.Point(132, 67);
            this.txtMatricula2.Name = "txtMatricula2";
            this.txtMatricula2.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula2.TabIndex = 5;
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(132, 110);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.Size = new System.Drawing.Size(100, 20);
            this.txtNome2.TabIndex = 6;
            // 
            // txtSalHora
            // 
            this.txtSalHora.Location = new System.Drawing.Point(191, 149);
            this.txtSalHora.Name = "txtSalHora";
            this.txtSalHora.Size = new System.Drawing.Size(100, 20);
            this.txtSalHora.TabIndex = 7;
            // 
            // txtDataEntEmp2
            // 
            this.txtDataEntEmp2.Location = new System.Drawing.Point(194, 195);
            this.txtDataEntEmp2.Name = "txtDataEntEmp2";
            this.txtDataEntEmp2.Size = new System.Drawing.Size(100, 20);
            this.txtDataEntEmp2.TabIndex = 8;
            // 
            // txtFaltas
            // 
            this.txtFaltas.Location = new System.Drawing.Point(194, 238);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(100, 20);
            this.txtFaltas.TabIndex = 9;
            // 
            // btnInstanciarH
            // 
            this.btnInstanciarH.Location = new System.Drawing.Point(332, 324);
            this.btnInstanciarH.Name = "btnInstanciarH";
            this.btnInstanciarH.Size = new System.Drawing.Size(111, 23);
            this.btnInstanciarH.TabIndex = 10;
            this.btnInstanciarH.Text = "Instanciar Horista";
            this.btnInstanciarH.UseVisualStyleBackColor = true;
            this.btnInstanciarH.Click += new System.EventHandler(this.BtnInstanciarH_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNao2);
            this.groupBox1.Controls.Add(this.rbtnSim2);
            this.groupBox1.Location = new System.Drawing.Point(511, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 148);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office";
            // 
            // rbtnSim2
            // 
            this.rbtnSim2.AutoSize = true;
            this.rbtnSim2.Location = new System.Drawing.Point(32, 43);
            this.rbtnSim2.Name = "rbtnSim2";
            this.rbtnSim2.Size = new System.Drawing.Size(42, 17);
            this.rbtnSim2.TabIndex = 0;
            this.rbtnSim2.TabStop = true;
            this.rbtnSim2.Text = "Sim";
            this.rbtnSim2.UseVisualStyleBackColor = true;
            // 
            // rbtnNao2
            // 
            this.rbtnNao2.AutoSize = true;
            this.rbtnNao2.Location = new System.Drawing.Point(32, 67);
            this.rbtnNao2.Name = "rbtnNao2";
            this.rbtnNao2.Size = new System.Drawing.Size(45, 17);
            this.rbtnNao2.TabIndex = 1;
            this.rbtnNao2.TabStop = true;
            this.rbtnNao2.Text = "Não";
            this.rbtnNao2.UseVisualStyleBackColor = true;
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInstanciarH);
            this.Controls.Add(this.txtFaltas);
            this.Controls.Add(this.txtDataEntEmp2);
            this.Controls.Add(this.txtSalHora);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.txtMatricula2);
            this.Controls.Add(this.lblFaltas);
            this.Controls.Add(this.lblDataEntEmp2);
            this.Controls.Add(this.lblSalHora);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblMatricula2);
            this.Name = "frmHorista";
            this.Text = "Horista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula2;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblSalHora;
        private System.Windows.Forms.Label lblDataEntEmp2;
        private System.Windows.Forms.Label lblFaltas;
        private System.Windows.Forms.TextBox txtMatricula2;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.TextBox txtSalHora;
        private System.Windows.Forms.TextBox txtDataEntEmp2;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.Button btnInstanciarH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNao2;
        private System.Windows.Forms.RadioButton rbtnSim2;
    }
}