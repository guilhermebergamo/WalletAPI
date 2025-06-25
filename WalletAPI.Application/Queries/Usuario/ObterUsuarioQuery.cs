
using MediatR;
using Wallet.Application.DTOs.Usuario;

namespace Wallet.Application.Queries.Usuario;
public class ObterUsuarioQuery : IRequest<UsuarioDTO>
{
    public ObterUsuarioQuery(Guid id)
    {
        Id = id;
    }
    public Guid Id { get; set; }
}