namespace AppExEscola01.Application.ViewModel
{
    //Campos de inserção de aluno - metodo POST
    //Antes de se matricular não há id e nem matrícula.
    public class AlunoCreateViewModel
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private string Cpf { get; set; }
        private string Cep { get; set; }
        private string DataNascimento { get; set; }

        public AlunoCreateViewModel() { }

        public AlunoCreateViewModel(string nome, string email, string cpf, string cep, string dataNascimento)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Cep = cep;
            DataNascimento = dataNascimento;
        }

        //Getter e Setter Nome

        public string GetNome() { return Nome; }

        public void SetNome(string value) { Nome = value; }

        //Getter e Setter CPF

        public string GetCpf() { return Cpf; }

        public void SetCpf(string value) { Cpf = value; }


        //Getter e Setter CEP
        public string GetCep() { return Cep; }

        public void SetCep(string value) { Cep = value; }

        //Getter e Setter Data de Nascimento

        public string GetDataNascimento() { return DataNascimento; }

        public void SetDataNascimento(string value) { DataNascimento = value; }

        //Getter e Setter Email

        public string GetEmail() { return Email; }

        public void SetEmail(string value) { Email = value; }
    }
}
