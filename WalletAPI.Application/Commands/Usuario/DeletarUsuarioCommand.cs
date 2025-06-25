namespace Wallet.Application.Commands.Usuario;
public class DeletarUsuarioCommand : Command
{
    public DeletarUsuarioCommand(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}