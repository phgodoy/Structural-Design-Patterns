using EncryptedFileDecorator.Decorators;
using EncryptedFileDecorator.Interfaces;
using EncryptedFileDecorator.Models;
using EncryptedFileDecorator.Services;
using EncryptedFileDecorator.Stores;

namespace EncryptedFileDecorator
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IEncryptionService encryptionService = new AesEncryptionService("Keytest");

            IUserDataStore baseStore = new UserDataStore();
            IUserDataStore encryptedStore = new EncryptedUserDataStore(baseStore, encryptionService);
            IUserDataStore validatedStore = new ValidatedUserDataStore(encryptedStore);

            var user = new User
            {
                Name = "João da Silva",
                Email = "joao.silva@empresacarochinha.com"
            };

            Console.WriteLine("\n> Salvando usuário criptografado...");
            await validatedStore.SaveAsync(user);
            Console.WriteLine("> Buscando usuário descriptografado...");
            var loadedUser = await encryptedStore.GetAsync(user.Id);

            Console.WriteLine($"\n Nome original: {user.Name}");
            Console.WriteLine($" Email original: {user.Email}");

            Console.WriteLine($"\n Nome descriptografado: {loadedUser.Name}");
            Console.WriteLine($" Email descriptografado: {loadedUser.Email}");
        }
    }
}
