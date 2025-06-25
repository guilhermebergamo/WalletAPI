using Wallet.Domain.Entities;
using Wallet.Domain.Interfaces.Repositories;
using Wallet.Infrastructure.Data;

namespace Wallet.Infrastructure.Repository;

public class UsuarioRepository(ApplicationDbContext _dbContext) 
    : IUsuarioRepository
{
    public async Task AdicionarUsuarioAsync(Usuario usuario)
    {
        await _dbContext.AddAsync(usuario);
        await _dbContext.SaveChangesAsync();
    }
}
