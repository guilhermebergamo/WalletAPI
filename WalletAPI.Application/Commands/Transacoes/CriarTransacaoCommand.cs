using Wallet.Application.DTOs.Transacao;

namespace Wallet.Application.Commands.Transacoes;
public class CriarTransacaoCommand : Command
{
    public CriarTransacaoCommand(TransacaoDTO transacaoDTO)
    {
        TransacaoDTO = transacaoDTO;

    }
    public TransacaoDTO TransacaoDTO { get; set; }
}