
using AutoMapper;
using MediatR;
using Wallet.Application.DTOs.Transacao;

namespace Wallet.Application.Queries.Transacao;

public class ObterTransferenciasPorUsuarioQueryHandler : IRequestHandler<ObterTransacaoPorUsuarioQuery, List<TransacaoDTO>>
{
    public Task<List<TransacaoDTO>> Handle(ObterTransacaoPorUsuarioQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
