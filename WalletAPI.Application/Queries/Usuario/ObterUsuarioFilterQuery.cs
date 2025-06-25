using MediatR;
using Wallet.Application.DTOs.Usuario;
using Wallet.Application.Models.Usuario;

namespace Wallet.Application.Queries.Usuario;
public class ObterUsuarioFilterQuery : IRequest<List<UsuarioDTO>>
{
    public ObterUsuarioFilterQuery(UsuarioFilterModel usuarioFilterModel)
    {
        UsuarioFilterModel = usuarioFilterModel;
    }
    public UsuarioFilterModel UsuarioFilterModel { get; set; }
}