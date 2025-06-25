
using Wallet.Domain.Entities;

namespace Wallet.Domain.Interfaces.Repositories;

public interface IUsuarioRepository
{
    Task AdicionarUsuarioAsync(Usuario usuario);
}
