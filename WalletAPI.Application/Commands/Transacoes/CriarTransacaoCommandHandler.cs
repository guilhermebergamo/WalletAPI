using MediatR;

namespace Wallet.Application.Commands.Transacoes;
public class CriarTransacaoCommandHandler : CommandHandler<CriarTransacaoCommand>
{
    public override Task<Unit> Handle(CriarTransacaoCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
