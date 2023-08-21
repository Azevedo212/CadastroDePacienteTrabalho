namespace CadastroPaciente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tx_nome = new TextBox();
            tx_cep = new TextBox();
            tx_telefone = new MaskedTextBox();
            tx_cpf = new MaskedTextBox();
            tx_rg = new TextBox();
            tx_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            bt_excluir = new Button();
            bt_cadastrar = new Button();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            tx_sexo = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            tx_rua = new TextBox();
            tx_bairro = new TextBox();
            tx_estado = new ComboBox();
            label15 = new Label();
            tx_cidade = new TextBox();
            label16 = new Label();
            tx_num = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            tx_celular = new MaskedTextBox();
            tx_cpf2 = new MaskedTextBox();
            tx_data = new MaskedTextBox();
            tx_responsavel = new TextBox();
            SuspendLayout();
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(82, 66);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(726, 23);
            tx_nome.TabIndex = 0;
            // 
            // tx_cep
            // 
            tx_cep.Location = new Point(81, 268);
            tx_cep.Name = "tx_cep";
            tx_cep.Size = new Size(150, 23);
            tx_cep.TabIndex = 1;
            tx_cep.TextChanged += tx_endereco_TextChanged;
            // 
            // tx_telefone
            // 
            tx_telefone.Location = new Point(82, 491);
            tx_telefone.Mask = "(00) 00000-0000";
            tx_telefone.Name = "tx_telefone";
            tx_telefone.Size = new Size(107, 23);
            tx_telefone.TabIndex = 2;
            // 
            // tx_cpf
            // 
            tx_cpf.Location = new Point(82, 114);
            tx_cpf.Mask = "000,000,000-00";
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(122, 23);
            tx_cpf.TabIndex = 3;
            // 
            // tx_rg
            // 
            tx_rg.Location = new Point(342, 114);
            tx_rg.Name = "tx_rg";
            tx_rg.Size = new Size(122, 23);
            tx_rg.TabIndex = 4;
            // 
            // tx_email
            // 
            tx_email.Location = new Point(82, 453);
            tx_email.Name = "tx_email";
            tx_email.Size = new Size(629, 23);
            tx_email.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 69);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 8;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 494);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 9;
            label2.Text = "Celular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 271);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 10;
            label3.Text = "CEP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 117);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 11;
            label4.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(311, 117);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 13;
            label6.Text = "RG:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(569, 117);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 14;
            label7.Text = "Data Nascimento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 456);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 15;
            label8.Text = "EMAIL:";
            // 
            // bt_excluir
            // 
            bt_excluir.Location = new Point(748, 659);
            bt_excluir.Name = "bt_excluir";
            bt_excluir.Size = new Size(89, 38);
            bt_excluir.TabIndex = 16;
            bt_excluir.Text = "EXCLUIR";
            bt_excluir.UseVisualStyleBackColor = true;
            bt_excluir.Click += bt_excluir_Click;
            // 
            // bt_cadastrar
            // 
            bt_cadastrar.Location = new Point(653, 659);
            bt_cadastrar.Name = "bt_cadastrar";
            bt_cadastrar.Size = new Size(89, 38);
            bt_cadastrar.TabIndex = 17;
            bt_cadastrar.Text = "CADASTRAR";
            bt_cadastrar.UseVisualStyleBackColor = true;
            bt_cadastrar.Click += bt_cadastrar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(546, 659);
            button1.Name = "button1";
            button1.Size = new Size(89, 38);
            button1.TabIndex = 19;
            button1.Text = "NOVO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 18);
            label9.Name = "label9";
            label9.Size = new Size(302, 45);
            label9.TabIndex = 21;
            label9.Text = "Informações\r\n-----------------------------------------------------------\r\n\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 160);
            label10.Name = "label10";
            label10.Size = new Size(35, 15);
            label10.TabIndex = 22;
            label10.Text = "Sexo:";
            // 
            // tx_sexo
            // 
            tx_sexo.DropDownStyle = ComboBoxStyle.DropDownList;
            tx_sexo.FormattingEnabled = true;
            tx_sexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Outro" });
            tx_sexo.Location = new Point(82, 157);
            tx_sexo.Name = "tx_sexo";
            tx_sexo.Size = new Size(121, 23);
            tx_sexo.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 226);
            label11.Name = "label11";
            label11.Size = new Size(317, 30);
            label11.TabIndex = 24;
            label11.Text = "Endereço\r\n--------------------------------------------------------------\r\n";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(46, 311);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 25;
            label12.Text = "Rua:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(35, 352);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 26;
            label13.Text = "Bairro:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(304, 271);
            label14.Name = "label14";
            label14.Size = new Size(45, 15);
            label14.TabIndex = 27;
            label14.Text = "Estado:";
            // 
            // tx_rua
            // 
            tx_rua.Location = new Point(81, 308);
            tx_rua.Name = "tx_rua";
            tx_rua.Size = new Size(431, 23);
            tx_rua.TabIndex = 28;
            // 
            // tx_bairro
            // 
            tx_bairro.Location = new Point(81, 349);
            tx_bairro.Name = "tx_bairro";
            tx_bairro.Size = new Size(431, 23);
            tx_bairro.TabIndex = 29;
            // 
            // tx_estado
            // 
            tx_estado.DropDownStyle = ComboBoxStyle.DropDownList;
            tx_estado.FormattingEnabled = true;
            tx_estado.Items.AddRange(new object[] { "Acre (AC)", "Alagoas (AL)", "Amapá (AP)", "Amazonas (AM)", "Bahia (BA)", "Ceará (CE)", "Distrito Federal (DF)", "Espírito Santo (ES)", "Goiás (GO)", "Maranhão (MA)", "Mato Grosso (MT)", "Mato Grosso do Sul (MS)", "Minas Gerais (MG)", "Pará (PA)", "Paraíba (PB)", "Paraná (PR)", "Pernambuco (PE)", "Piauí (PI)", "Rio de Janeiro (RJ)", "Rio Grande do Norte (RN)", "Rio Grande do Sul (RS)", "Rondônia (RO)", "Roraima (RR)", "Santa Catarina (SC)", "São Paulo (SP)", "Sergipe (SE)", "Tocantins (TO)" });
            tx_estado.Location = new Point(355, 268);
            tx_estado.Name = "tx_estado";
            tx_estado.Size = new Size(157, 23);
            tx_estado.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(600, 271);
            label15.Name = "label15";
            label15.Size = new Size(47, 15);
            label15.TabIndex = 31;
            label15.Text = "Cidade:";
            // 
            // tx_cidade
            // 
            tx_cidade.Location = new Point(651, 268);
            tx_cidade.Name = "tx_cidade";
            tx_cidade.Size = new Size(156, 23);
            tx_cidade.TabIndex = 32;
            tx_cidade.TextChanged += textBox3_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(685, 311);
            label16.Name = "label16";
            label16.Size = new Size(24, 15);
            label16.TabIndex = 33;
            label16.Text = "N°:";
            // 
            // tx_num
            // 
            tx_num.Location = new Point(715, 308);
            tx_num.Name = "tx_num";
            tx_num.Size = new Size(92, 23);
            tx_num.TabIndex = 35;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(12, 412);
            label18.Name = "label18";
            label18.Size = new Size(187, 30);
            label18.TabIndex = 36;
            label18.Text = "Contato\r\n------------------------------------\r\n";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(12, 537);
            label19.Name = "label19";
            label19.Size = new Size(192, 30);
            label19.TabIndex = 37;
            label19.Text = "Responsável\r\n-------------------------------------\r\n";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(31, 573);
            label20.Name = "label20";
            label20.Size = new Size(43, 15);
            label20.TabIndex = 38;
            label20.Text = "Nome:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(639, 573);
            label21.Name = "label21";
            label21.Size = new Size(31, 15);
            label21.TabIndex = 41;
            label21.Text = "CPF:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(28, 610);
            label22.Name = "label22";
            label22.Size = new Size(47, 15);
            label22.TabIndex = 42;
            label22.Text = "Celular:";
            // 
            // tx_celular
            // 
            tx_celular.Location = new Point(81, 607);
            tx_celular.Mask = "(00) 00000-0000";
            tx_celular.Name = "tx_celular";
            tx_celular.Size = new Size(107, 23);
            tx_celular.TabIndex = 43;
            // 
            // tx_cpf2
            // 
            tx_cpf2.Location = new Point(676, 570);
            tx_cpf2.Mask = "000,000,000-00";
            tx_cpf2.Name = "tx_cpf2";
            tx_cpf2.Size = new Size(131, 23);
            tx_cpf2.TabIndex = 44;
            // 
            // tx_data
            // 
            tx_data.Location = new Point(676, 114);
            tx_data.Mask = "00/00/00";
            tx_data.Name = "tx_data";
            tx_data.Size = new Size(131, 23);
            tx_data.TabIndex = 45;
            // 
            // tx_responsavel
            // 
            tx_responsavel.Location = new Point(82, 570);
            tx_responsavel.Name = "tx_responsavel";
            tx_responsavel.Size = new Size(430, 23);
            tx_responsavel.TabIndex = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 724);
            Controls.Add(tx_responsavel);
            Controls.Add(tx_data);
            Controls.Add(tx_cpf2);
            Controls.Add(tx_celular);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(tx_num);
            Controls.Add(label16);
            Controls.Add(tx_cidade);
            Controls.Add(label15);
            Controls.Add(tx_estado);
            Controls.Add(tx_bairro);
            Controls.Add(tx_rua);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(tx_sexo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(bt_cadastrar);
            Controls.Add(bt_excluir);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tx_email);
            Controls.Add(tx_rg);
            Controls.Add(tx_cpf);
            Controls.Add(tx_telefone);
            Controls.Add(tx_cep);
            Controls.Add(tx_nome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            tx_bairro.TextChanged += textBox2_TextChanged;
        }

        #endregion

        private TextBox tx_nome;
        private TextBox tx_cep;
        private MaskedTextBox tx_telefone;
        private MaskedTextBox tx_cpf;
        private TextBox tx_rg;
        private TextBox tx_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button bt_excluir;
        private Button bt_cadastrar;
        private Button button1;
        private Label label9;
        private Label label10;
        private ComboBox tx_sexo;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox tx_rua;
        private TextBox tx_bairro;
        private ComboBox tx_estado;
        private Label label15;
        private TextBox tx_cidade;
        private Label label16;
        private TextBox tx_num;
        private Label label18;
        private Label label19;
        private Label label20;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label21;
        private Label label22;
        private MaskedTextBox tx_celular;
        private MaskedTextBox tx_cpf2;
        private MaskedTextBox tx_data;
        private TextBox tx_responsavel;
    }
}