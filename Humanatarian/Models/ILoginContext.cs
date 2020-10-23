namespace Humanatarian.Models
{
    public interface ILoginContext
    {
        bool IsValidLogin(LoginModel login);
    }
}