using Wallet.SharedKernel.Domain;

namespace Wallet.Domain.Entities;
public class Wallet(Guid id, Guid usuarioId, decimal saldo = 0)
    : Entity<Guid>(id)
{
    protected Wallet() : this(Guid.Empty, Guid.Empty, 0) { }

    public Guid UsuarioId { get; private set; } = usuarioId;
    public decimal Saldo { get; private set; } = saldo;

    public virtual Usuario Usuario { get; private set; }

    public void AdicionarSaldo(decimal valor)
    {
        Saldo += valor;
    }

    public void SubtrairSaldo(decimal valor)
    {
        if (Saldo < valor) throw new InvalidOperationException("Saldo insuficiente");

        Saldo -= valor;
    }
}
