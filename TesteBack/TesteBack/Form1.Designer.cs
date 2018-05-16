namespace TesteBack
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.activit_true = new System.Windows.Forms.RadioButton();
            this.activit_false = new System.Windows.Forms.RadioButton();
            this.btn_massive_add = new System.Windows.Forms.Button();
            this.lb_teste = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.lb_média = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_select = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(49, 243);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 23);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Cadastrar";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(21, 65);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(134, 20);
            this.tb_name.TabIndex = 2;
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(21, 112);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(134, 20);
            this.tb_cpf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "cpf/cnpj";
            // 
            // tb_value
            // 
            this.tb_value.Location = new System.Drawing.Point(21, 155);
            this.tb_value.Name = "tb_value";
            this.tb_value.Size = new System.Drawing.Size(134, 20);
            this.tb_value.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // activit_true
            // 
            this.activit_true.AutoSize = true;
            this.activit_true.Checked = true;
            this.activit_true.Location = new System.Drawing.Point(21, 198);
            this.activit_true.Name = "activit_true";
            this.activit_true.Size = new System.Drawing.Size(49, 17);
            this.activit_true.TabIndex = 8;
            this.activit_true.TabStop = true;
            this.activit_true.Text = "Ativo";
            this.activit_true.UseVisualStyleBackColor = true;
            // 
            // activit_false
            // 
            this.activit_false.AutoSize = true;
            this.activit_false.Location = new System.Drawing.Point(86, 198);
            this.activit_false.Name = "activit_false";
            this.activit_false.Size = new System.Drawing.Size(57, 17);
            this.activit_false.TabIndex = 9;
            this.activit_false.Text = "Inativo";
            this.activit_false.UseVisualStyleBackColor = true;
            // 
            // btn_massive_add
            // 
            this.btn_massive_add.Enabled = false;
            this.btn_massive_add.Location = new System.Drawing.Point(182, 368);
            this.btn_massive_add.Name = "btn_massive_add";
            this.btn_massive_add.Size = new System.Drawing.Size(302, 23);
            this.btn_massive_add.TabIndex = 10;
            this.btn_massive_add.Text = "Adicionar 3000 pessoas no banco";
            this.btn_massive_add.UseVisualStyleBackColor = true;
            this.btn_massive_add.Click += new System.EventHandler(this.btn_massive_add_Click);
            // 
            // lb_teste
            // 
            this.lb_teste.AutoSize = true;
            this.lb_teste.Location = new System.Drawing.Point(399, 63);
            this.lb_teste.Name = "lb_teste";
            this.lb_teste.Size = new System.Drawing.Size(0, 13);
            this.lb_teste.TabIndex = 11;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(409, 243);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 13;
            this.btn_select.Text = "Buscar";
            this.btn_select.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lb_média
            // 
            this.lb_média.AutoSize = true;
            this.lb_média.Location = new System.Drawing.Point(399, 296);
            this.lb_média.Name = "lb_média";
            this.lb_média.Size = new System.Drawing.Size(0, 13);
            this.lb_média.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(548, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Consulta para valores maiores que 560 que estejam entre os clientes 1500 e 2700 e" +
    "m ordem decrescente do valor.";
            // 
            // lb_select
            // 
            this.lb_select.FormattingEnabled = true;
            this.lb_select.Location = new System.Drawing.Point(167, 65);
            this.lb_select.Name = "lb_select";
            this.lb_select.Size = new System.Drawing.Size(545, 147);
            this.lb_select.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 403);
            this.Controls.Add(this.lb_select);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_média);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.lb_teste);
            this.Controls.Add(this.btn_massive_add);
            this.Controls.Add(this.activit_false);
            this.Controls.Add(this.activit_true);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_insert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton activit_true;
        private System.Windows.Forms.RadioButton activit_false;
        private System.Windows.Forms.Button btn_massive_add;
        private System.Windows.Forms.Label lb_teste;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label lb_média;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_select;
    }
}

