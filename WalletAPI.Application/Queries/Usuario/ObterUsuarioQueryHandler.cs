
using MediatR;
using Wallet.Application.DTOs.Usuario;

namespace Wallet.Application.Queries.Usuario;
public class ObterUsuarioQueryHandler : IRequestHandler<ObterUsuarioQuery, UsuarioDTO>
{
    public Task<UsuarioDTO> Handle(ObterUsuarioQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
