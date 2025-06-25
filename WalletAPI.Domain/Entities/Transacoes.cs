using Wallet.SharedKernel.Domain;

namespace Wallet.Domain.Entities;
public class Transacoes(Guid id, Guid fromUsuarioId, Guid toUsuarioId, decimal valor, DateTime dataHora)
    : Entity<Guid>(id)
{
    protected Transacoes() : this(Guid.Empty, Guid.Empty, Guid.Empty, 0, DateTime.MinValue) { }

    public Guid FromUsuarioId { get; private set; } = fromUsuarioId;
    public Guid ToUsuarioId { get; private set; } = toUsuarioId;
    public decimal Valor { get; private set; } = valor;
    public DateTime DataHora { get; private set; } = dataHora;

    public virtual Usuario FromUsuario { get; private set; }
    public virtual Usuario ToUsuario { get; private set; }
}

