using EncryptedFileDecorator.Interfaces;
using EncryptedFileDecorator.Models;

namespace EncryptedFileDecorator.Stores
{
    public class UserDataStore : IUserDataStore
    {
        private readonly Dictionary<Guid, User> _storage = new();

        public Task SaveAsync(User user)
        {
            _storage[user.Id] = user;
            return Task.CompletedTask;
        }

        public Task<User> GetAsync(Guid id)
        {
            _storage.TryGetValue(id, out var user);
            return Task.FromResult(user);
        }
    }
}

