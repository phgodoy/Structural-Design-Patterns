using EncryptedFileDecorator.Interfaces;
using EncryptedFileDecorator.Models;

namespace EncryptedFileDecorator.Decorators
{
    public class EncryptedUserDataStore : IUserDataStore
    {
        private readonly IUserDataStore _inner;
        private readonly IEncryptionService _encryption;

        public EncryptedUserDataStore(IUserDataStore inner, IEncryptionService encryption)
        {
            _inner = inner;
            _encryption = encryption;
        }

        public async Task SaveAsync(User user)
        {
            var encryptedUser = new User
            {
                Id = user.Id,
                Name = _encryption.Encrypt(user.Name),
                Email = _encryption.Encrypt(user.Email)
            };

            await _inner.SaveAsync(encryptedUser);
        }

        public async Task<User?> GetAsync(Guid id)
        {
            var user = await _inner.GetAsync(id);

            if (user != null)
            {
                user.Name = _encryption.Decrypt(user.Name);
                user.Email = _encryption.Decrypt(user.Email);
            }
            
            return user;
        }
    }
}
