using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wallet.Application.Queries.Transacao;

namespace Wallet.Api.Controllers.Transferencias;

[ApiController]
[Route("[controller]")]
public class TransacoesController : ControllerBase
{
    private readonly IMediator _mediator;

    [HttpGet("usuarios/{id}/Transacoes")]
    public async Task<IActionResult> ObterTransacoes(Guid id, [FromQuery] DateTime? dataInicio, [FromQuery] DateTime? dataFim)
    {
        var query = new ObterTransacaoPorUsuarioQuery(id, dataInicio, dataFim);
        var resultado = await _mediator.Send(query);

        return Ok(resultado);
    }
}
