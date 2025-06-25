using Wallet.Application.DTOs.Usuario;

namespace Wallet.Application.Commands.Usuario;
public class CriarUsuarioCommand : Command
{
    public CriarUsuarioCommand(UsuarioDTO usuarioDTO)
    {
        UsuarioDTO = usuarioDTO;
    }
    public UsuarioDTO UsuarioDTO { get; set; }
}