
namespace Wallet.Application.DTOs.Transacao;
public record TransacaoDTO
(
    Guid Id,
    Guid FromUsuarioId,
    Guid ToUsuarioId,
    decimal Valor,
    DateTime DataHora
);