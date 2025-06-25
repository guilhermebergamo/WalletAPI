namespace Wallet.Application.DTOs.Usuario;
public record UsuarioDTO
(
    string? Nome,
    string SobreNome,
    string Cpf,
    DateTime DataNascimento
);