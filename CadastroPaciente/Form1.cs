using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace CadastroPaciente
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            CadPaciente paciente = new CadPaciente(); //metodo Construtor

            //Paciente informa��es
            paciente.Nome = tx_nome.Text;
            paciente.CPF = tx_cpf.Text;
            paciente.RG = tx_rg.Text;
            paciente.Data = tx_data.Text;
            paciente.Sexo = tx_sexo.Text;


            //Endere�o do paciente
            paciente.Cep = tx_cep.Text;
            paciente.Estado = tx_estado.Text;
            paciente.Cidade = tx_cidade.Text;
            paciente.Rua = tx_rua.Text;
            paciente.Num = tx_num.Text;
            paciente.Bairro = tx_bairro.Text;


            //Contato do paciente
            paciente.Email = tx_email.Text;
            paciente.Telefone = tx_telefone.Text;


            //Respons�vel do paciente
            paciente.Responsavel = tx_responsavel.Text;
            paciente.Cpf2 = tx_cpf2.Text;
            paciente.Celular = tx_celular.Text;


            if (Validar()) //validando se os campos obrigat�rios foram preenchidos
            {              
                string texto = "D:\\IFRO\\poo\\TRABALHO\\cadastroPaciente.txt"; //direcionando o arquivo txt a uma vari�vel

                //streamWriter � um m�todo e sw � o nome do objeto que estou declarando para  escrever em um arquivo de texto

                //StreamWriter sw = new StreamWriter(texto); //o Writer sobreescreve o arquivo txt

                StreamWriter sw = File.AppendText(texto);       
                sw.WriteLine("FICHA PACIENTE" + "\n\n");
                sw.WriteLine("Informa��es Paciente \n");
                
                sw.WriteLine("Nome: " + paciente.Nome);
                sw.WriteLine("CPF: " + paciente.CPF);
                sw.WriteLine("RG: " + paciente.RG);
                sw.WriteLine("Data de Nascimento: " + paciente.Data);
                sw.WriteLine("Sexo: " + paciente.Sexo);
                sw.WriteLine("_____________________________________________________________________________________________________________________________ \n");


                sw.WriteLine("ENDERE�O \n");
                
                sw.WriteLine("CEP: " + paciente.Cep);
                sw.WriteLine("Estado: " + paciente.Estado);
                sw.WriteLine("Cidade: " + paciente.Cidade);
                sw.WriteLine("Rua: " + paciente.Rua);
                sw.WriteLine("Num: " + paciente.Num);
                sw.WriteLine("Bairro: " + paciente.Bairro + "\n");
                sw.WriteLine("____________________________________________________________________________________________________________________________ \n");

                sw.WriteLine("CONTATO \n");
                
                sw.WriteLine("Email: " + paciente.Email);
                sw.WriteLine("Celular: " + paciente.Telefone + "\n");
                sw.WriteLine("____________________________________________________________________________________________________________________________ \n");

                sw.WriteLine("RESPONS�VEL \n");
                
                sw.WriteLine("Nome: " + paciente.Responsavel);
                sw.WriteLine("Cpf: " + paciente.Cpf2);
                sw.WriteLine("Celular: " + paciente.Celular + "\n");
                sw.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// \n \n \n \n");
                sw.Close();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!!");
                MessageBox.Show("Os campos {Informa��es do paciente}, {Contato} e {Respons�vel} s�o obrigat�rios!");
            }

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_rg.Clear();
            tx_data.Clear();
            tx_sexo.ResetText();
            tx_cep.Clear();
            tx_estado.ResetText();
            tx_cidade.Clear();
            tx_rua.Clear();
            tx_num.Clear();
            tx_bairro.Clear();
            tx_email.Clear();
            tx_telefone.Clear();
            tx_responsavel.Clear();
            tx_cpf2.Clear();
            tx_celular.Clear();
                                                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_cpf.Clear();
            tx_rg.Clear();
            tx_data.Clear();
            tx_sexo.ResetText();
            tx_cep.Clear();
            tx_estado.ResetText();
            tx_cidade.Clear();
            tx_rua.Clear();
            tx_num.Clear();
            tx_bairro.Clear();
            tx_email.Clear();
            tx_telefone.Clear();
            tx_responsavel.Clear();
            tx_cpf2.Clear();
            tx_celular.Clear();
        }

        public bool Validar() //M�todo para de valida��o para digitar obrigar a digitar todos os campos obrig�torios
        {
            bool validacao;

            if (tx_nome.Text == "")
            {
                validacao = false;
            }
            else if (tx_cpf.Text == "")
            {
                validacao = false;
            }
            else if (tx_rg.Text == "")
            {
                validacao = false;
            }
            else if (tx_data.Text == "")
            {
                validacao = false;
            }
            else if (tx_sexo.Text == "")
            {
                validacao = false;
            }
            else if (tx_email.Text == "")
            {
                validacao = false;
            }
            else if (tx_telefone.Text == "")
            {
                validacao = false;
            }
            else if (tx_responsavel.Text == "")
            {
                validacao = false;
            }
            else if (tx_cpf2.Text == "")
            {
                validacao = false;
            }
            else if (tx_celular.Text == "")
            {
                validacao = false;
            }
            else
            {
                validacao = true;
            }

            return validacao;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}