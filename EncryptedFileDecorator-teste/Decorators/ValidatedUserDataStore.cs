using EncryptedFileDecorator.Interfaces;
using EncryptedFileDecorator.Models;

namespace EncryptedFileDecorator.Decorators
{
    public class ValidatedUserDataStore : IUserDataStore
    {
        private readonly IUserDataStore _inner;

        public ValidatedUserDataStore(IUserDataStore inner)
        {
            _inner = inner;
        }

        public async Task SaveAsync(User user)
        {
            if (!user.Email.EndsWith("@empresacarochinha.com", StringComparison.OrdinalIgnoreCase))
            {
                throw new InvalidOperationException(
                    $"O email '{user.Email}' não é válido. Deve terminar com '@empresacarochinha.com'."
                );
            }

            await _inner.SaveAsync(user);
        }

        public Task<User> GetAsync(Guid id)
        {
            return _inner.GetAsync(id);
        }
    }
}
