public class CadPaciente
{
    public string Nome { get; set; }

    public string Telefone { get; set; }

    public string Endereco { get; set; }

    public string CPF { get; set; }

    public string RG { get; set; }

    public string Plano { get; set; }

    public string Data { get; set; }

    public string Email { get; set; }

    public string Sexo { get; set; }

    public string Cep { get; set; }

    public string Cidade { get; set; }

    public string Estado { get; set; }

    public string Rua { get; set; }

    public string Num { get; set; }

    public string Bairro { get; set; }

    public string Responsavel { get; set; }

    public string Cpf2 { get; set; }

    public string Celular { get; set; }

    public CadPaciente()
    {

    }

    public CadPaciente(string Nome, string Telefone, string Endereco, string CPF, string RG, string Plano,
        string Data, string Email, string Sexo, string Cep, string Cidade, string Estado, string Rua, string Num, string Bairro,
        string Responsavel, string Cpf2, string Celular)
    {
        this.Nome = Nome;
        this.Telefone = Telefone;
        this.Endereco = Endereco;
        this.CPF = CPF;
        this.RG = RG;
        this.Plano = Plano;
        this.Data = Data;
        this.Email = Email;
        this.Sexo = Sexo;
        this.Cep = Cep;
        this.Estado = Estado;
        this.Cidade = Cidade;
        this.Responsavel = Responsavel;
        this.Cpf2 = Cpf2;
        this.Celular = Celular;
        
    }

    
}