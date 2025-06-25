
using MediatR;

namespace Wallet.Application.Commands.Usuario;

public class AtualizarUsuarioCommandHandler : CommandHandler<AtualizarUsuarioCommand>
{
    public override Task<Unit> Handle(AtualizarUsuarioCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
