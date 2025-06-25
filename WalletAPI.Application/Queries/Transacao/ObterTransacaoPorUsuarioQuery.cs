using MediatR;
using Wallet.Application.DTOs.Transacao;

namespace Wallet.Application.Queries.Transacao;
public class ObterTransacaoPorUsuarioQuery : IRequest<List<TransacaoDTO>>
{
    public ObterTransacaoPorUsuarioQuery(Guid usuarioId, DateTime? dataInicio = null, DateTime? dataFim = null)
    {
        UsuarioId = usuarioId;
        DataInicio = dataInicio;
        DataFim = dataFim;
    }

    public Guid UsuarioId { get; set; }
    public DateTime? DataInicio { get; set; }
    public DateTime? DataFim{ get; set; }
}