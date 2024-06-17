using System.IdentityModel.Tokens.Jwt;
using AuthSystem.Dtos;

namespace AuthSystem.Services;

public interface IAuthenticationService
{
    Task<string> Register(RegisterRequest request);
    Task<string> Login(LoginRequest request);
}