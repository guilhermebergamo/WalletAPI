using Wallet.SharedKernel.Domain;

namespace Wallet.Domain.Entities;

public class Usuario(string nome, string sobrenome, string cpf, DateTime dataNascimento)
    : Entity<Guid>(Guid.NewGuid())
{
    protected Usuario() : this(string.Empty, string.Empty, string.Empty, DateTime.MinValue) { }

    public string Nome { get; private set; } = nome;
    public string SobreNome { get; private set; } = sobrenome;
    public string Cpf { get; private set; } = cpf;
    public DateTime DataNascimento { get; private set; } = dataNascimento;

    public virtual Wallet Wallet { get; private set; }
}
