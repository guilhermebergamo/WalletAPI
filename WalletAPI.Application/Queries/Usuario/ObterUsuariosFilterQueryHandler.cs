using MediatR;
using Wallet.Application.DTOs.Usuario;

namespace Wallet.Application.Queries.Usuario;
public class ObterUsuariosFilterQueryHandler : IRequestHandler<ObterUsuarioFilterQuery, List<UsuarioDTO>>
{
    public Task<List<UsuarioDTO>> Handle(ObterUsuarioFilterQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

