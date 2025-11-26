using EncryptedFileDecorator.Models;
namespace EncryptedFileDecorator.Interfaces
{
    public interface IUserDataStore
    {
        Task SaveAsync(User user);
        Task<User> GetAsync(Guid id);
    }
}
