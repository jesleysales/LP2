namespace pclasses
{
    partial class frmMensalista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalMen = new System.Windows.Forms.Label();
            this.lblDataEntEmp = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDatEntEmpr = new System.Windows.Forms.TextBox();
            this.txtSalMensal = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbHomeOffice = new System.Windows.Forms.GroupBox();
            this.rbtnNão = new System.Windows.Forms.RadioButton();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.btnInstanciarM = new System.Windows.Forms.Button();
            this.btnInstanciarMPara = new System.Windows.Forms.Button();
            this.gpbHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(56, 47);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(56, 85);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalMen
            // 
            this.lblSalMen.AutoSize = true;
            this.lblSalMen.Location = new System.Drawing.Point(56, 121);
            this.lblSalMen.Name = "lblSalMen";
            this.lblSalMen.Size = new System.Drawing.Size(76, 13);
            this.lblSalMen.TabIndex = 2;
            this.lblSalMen.Text = "Salario Mensal";
            // 
            // lblDataEntEmp
            // 
            this.lblDataEntEmp.AutoSize = true;
            this.lblDataEntEmp.Location = new System.Drawing.Point(56, 163);
            this.lblDataEntEmp.Name = "lblDataEntEmp";
            this.lblDataEntEmp.Size = new System.Drawing.Size(129, 13);
            this.lblDataEntEmp.TabIndex = 3;
            this.lblDataEntEmp.Text = "Data Entrada na Empresa";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(209, 47);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 4;
            // 
            // txtDatEntEmpr
            // 
            this.txtDatEntEmpr.Location = new System.Drawing.Point(209, 156);
            this.txtDatEntEmpr.Name = "txtDatEntEmpr";
            this.txtDatEntEmpr.Size = new System.Drawing.Size(100, 20);
            this.txtDatEntEmpr.TabIndex = 5;
            // 
            // txtSalMensal
            // 
            this.txtSalMensal.Location = new System.Drawing.Point(209, 121);
            this.txtSalMensal.Name = "txtSalMensal";
            this.txtSalMensal.Size = new System.Drawing.Size(100, 20);
            this.txtSalMensal.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(209, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // gpbHomeOffice
            // 
            this.gpbHomeOffice.Controls.Add(this.rbtnNão);
            this.gpbHomeOffice.Controls.Add(this.rbtnSim);
            this.gpbHomeOffice.Location = new System.Drawing.Point(530, 68);
            this.gpbHomeOffice.Name = "gpbHomeOffice";
            this.gpbHomeOffice.Size = new System.Drawing.Size(200, 100);
            this.gpbHomeOffice.TabIndex = 8;
            this.gpbHomeOffice.TabStop = false;
            this.gpbHomeOffice.Text = "Trabalha em home office";
            this.gpbHomeOffice.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rbtnNão
            // 
            this.rbtnNão.AutoSize = true;
            this.rbtnNão.Location = new System.Drawing.Point(29, 51);
            this.rbtnNão.Name = "rbtnNão";
            this.rbtnNão.Size = new System.Drawing.Size(45, 17);
            this.rbtnNão.TabIndex = 1;
            this.rbtnNão.TabStop = true;
            this.rbtnNão.Text = "Não";
            this.rbtnNão.UseVisualStyleBackColor = true;
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(29, 20);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(42, 17);
            this.rbtnSim.TabIndex = 0;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            // 
            // btnInstanciarM
            // 
            this.btnInstanciarM.Location = new System.Drawing.Point(209, 302);
            this.btnInstanciarM.Name = "btnInstanciarM";
            this.btnInstanciarM.Size = new System.Drawing.Size(132, 23);
            this.btnInstanciarM.TabIndex = 9;
            this.btnInstanciarM.Text = "Instanciar Mensalista";
            this.btnInstanciarM.UseVisualStyleBackColor = true;
            this.btnInstanciarM.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnInstanciarMPara
            // 
            this.btnInstanciarMPara.Location = new System.Drawing.Point(464, 302);
            this.btnInstanciarMPara.Name = "btnInstanciarMPara";
            this.btnInstanciarMPara.Size = new System.Drawing.Size(227, 23);
            this.btnInstanciarMPara.TabIndex = 10;
            this.btnInstanciarMPara.Text = "Instanciar Mensalista passando parâmetro";
            this.btnInstanciarMPara.UseVisualStyleBackColor = true;
            this.btnInstanciarMPara.Click += new System.EventHandler(this.BtnInstanciarMPara_Click);
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstanciarMPara);
            this.Controls.Add(this.btnInstanciarM);
            this.Controls.Add(this.gpbHomeOffice);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalMensal);
            this.Controls.Add(this.txtDatEntEmpr);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblDataEntEmp);
            this.Controls.Add(this.lblSalMen);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "Mensalista";
            this.gpbHomeOffice.ResumeLayout(false);
            this.gpbHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalMen;
        private System.Windows.Forms.Label lblDataEntEmp;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDatEntEmpr;
        private System.Windows.Forms.TextBox txtSalMensal;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbHomeOffice;
        private System.Windows.Forms.RadioButton rbtnNão;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.Button btnInstanciarM;
        private System.Windows.Forms.Button btnInstanciarMPara;
    }
}