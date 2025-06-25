using MediatR;
using Microsoft.AspNetCore.Mvc;
using Wallet.Application.Commands.Usuario;
using Wallet.Application.DTOs.Usuario;

namespace Wallet.Api.Controllers.Transferencias;

[ApiController]
[Route("[controller]")]
public class UsuarioController(IMediator _mediator) 
    : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Adicionar(UsuarioDTO request)
    {
        var _ = await _mediator.Send(new CriarUsuarioCommand(request));
        return Ok();
    }
}
