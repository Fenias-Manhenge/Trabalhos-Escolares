namespace GestaoProfessor
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDiaTrabal = new System.Windows.Forms.TextBox();
            this.txtSalDia = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.lstVTabela = new System.Windows.Forms.ListView();
            this.lstVItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstVNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstVDTrabalh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstVSalDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstVSalMens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "WORKED DAYS";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "DAILY SALARY";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(146, 39);
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(151, 20);
            this.txtCode.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtCode, "Digite o codigo aqui");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtDiaTrabal
            // 
            this.txtDiaTrabal.Location = new System.Drawing.Point(146, 96);
            this.txtDiaTrabal.Name = "txtDiaTrabal";
            this.txtDiaTrabal.Size = new System.Drawing.Size(151, 20);
            this.txtDiaTrabal.TabIndex = 6;
            // 
            // txtSalDia
            // 
            this.txtSalDia.Location = new System.Drawing.Point(146, 122);
            this.txtSalDia.Name = "txtSalDia";
            this.txtSalDia.Size = new System.Drawing.Size(151, 20);
            this.txtSalDia.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(413, 36);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(413, 63);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(124, 23);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lstVTabela
            // 
            this.lstVTabela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lstVItem,
            this.lstVNome,
            this.lstVDTrabalh,
            this.lstVSalDia,
            this.lstVSalMens});
            this.lstVTabela.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVTabela.HideSelection = false;
            this.lstVTabela.Location = new System.Drawing.Point(48, 198);
            this.lstVTabela.Name = "lstVTabela";
            this.lstVTabela.Size = new System.Drawing.Size(687, 225);
            this.lstVTabela.TabIndex = 10;
            this.lstVTabela.UseCompatibleStateImageBehavior = false;
            this.lstVTabela.View = System.Windows.Forms.View.Details;
            // 
            // lstVItem
            // 
            this.lstVItem.Text = "CODIGO";
            this.lstVItem.Width = 117;
            // 
            // lstVNome
            // 
            this.lstVNome.Text = "NOME";
            this.lstVNome.Width = 196;
            // 
            // lstVDTrabalh
            // 
            this.lstVDTrabalh.Text = "DIAS TRABALHADOS";
            this.lstVDTrabalh.Width = 139;
            // 
            // lstVSalDia
            // 
            this.lstVSalDia.Text = "SALARIO DIARIO";
            this.lstVSalDia.Width = 112;
            // 
            // lstVSalMens
            // 
            this.lstVSalMens.Text = "SALARIO MENSAL";
            this.lstVSalMens.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVTabela);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSalDia);
            this.Controls.Add(this.txtDiaTrabal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDiaTrabal;
        private System.Windows.Forms.TextBox txtSalDia;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListView lstVTabela;
        private System.Windows.Forms.ColumnHeader lstVItem;
        private System.Windows.Forms.ColumnHeader lstVNome;
        private System.Windows.Forms.ColumnHeader lstVDTrabalh;
        private System.Windows.Forms.ColumnHeader lstVSalDia;
        private System.Windows.Forms.ColumnHeader lstVSalMens;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

