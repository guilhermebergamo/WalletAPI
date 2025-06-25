using AutoMapper;
using Wallet.Application.DTOs.Usuario;
using Wallet.Domain.Entities;

namespace Teste.Usuarios.Domain.Profiles;
public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<Usuario, UsuarioDTO>();
        CreateMap<UsuarioDTO, Usuario>();
    }
}