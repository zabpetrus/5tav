namespace AppExEscola01.Domain.Validation.Interfaces
{
    internal interface IValidaNome
    {
        bool validarTamanhoNome(string nome);
        bool validarCaracteresNome(string nome);
    }
}
