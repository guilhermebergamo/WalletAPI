namespace Wallet.SharedKernel.Domain;
public abstract class Entity<TId>
{
    protected Entity(TId id)
    {
        Id = id;
    }

    public TId Id { get; protected set; }
}