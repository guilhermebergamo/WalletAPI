using MediatR;

namespace Wallet.Application.Commands.Usuario;

public class DeletarUsuarioCommandHandler : CommandHandler<DeletarUsuarioCommand>
{
    public override Task<Unit> Handle(DeletarUsuarioCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
