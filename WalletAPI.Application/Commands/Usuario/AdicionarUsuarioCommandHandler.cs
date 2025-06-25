using AutoMapper;
using MediatR;
using Wallet.Domain.Interfaces.Repositories;

namespace Wallet.Application.Commands.Usuario;
public class AdicionarUsuarioCommandHandler(IUsuarioRepository _usuarioRepository, IMapper _mapper) 
    : CommandHandler<CriarUsuarioCommand>
{
    public override async Task<Unit> Handle(CriarUsuarioCommand command, CancellationToken cancellationToken)
    {        
        var usuario = _mapper.Map<Wallet.Domain.Entities.Usuario>(command.UsuarioDTO);
        await _usuarioRepository.AdicionarUsuarioAsync(usuario);

        return Unit.Value;
    }
}