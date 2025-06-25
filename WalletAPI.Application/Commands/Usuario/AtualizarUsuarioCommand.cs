using Wallet.Application.DTOs.Usuario;

namespace Wallet.Application.Commands.Usuario;
public class AtualizarUsuarioCommand : Command
{
    public AtualizarUsuarioCommand(UsuarioDTO usuarioDTO)
    {
        UsuarioDTO = usuarioDTO;
    }
    public UsuarioDTO UsuarioDTO { get; set; }  
}