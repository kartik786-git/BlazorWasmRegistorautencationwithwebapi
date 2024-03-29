using BlazorAppSecure.Model;

namespace BlazorAppSecure.Sevices
{
    public interface IAccountManagement
    {
        public Task<FormResult> RegisterAsync(string email, string password);
    }
}
