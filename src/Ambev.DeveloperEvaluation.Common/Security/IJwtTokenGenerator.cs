using Ambev.DeveloperEvaluation.Common.Security.Entities;

namespace Ambev.DeveloperEvaluation.Common.Security
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(IUser user);
    }
}
