using BridgeDemo.Devices.Interfaces;
using BridgeDemo.Devices;
using BridgeDemo.Remotes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("== Bridge Pattern Demo ==\n");


        IDevice tv = new Tv();
        IDevice radio = new Radio();


        RemoteControl remoteForTv = new RemoteControl(tv);
        AdvancedRemote advRemoteForRadio = new AdvancedRemote(radio);


        Console.WriteLine("--- Usando RemoteControl com TV ---");
        remoteForTv.TogglePower();
        remoteForTv.VolumeUp();
        remoteForTv.VolumeUp();
        remoteForTv.ChannelUp();
        remoteForTv.ChannelUp();
        remoteForTv.TogglePower();


        Console.WriteLine();


        Console.WriteLine("--- Usando AdvancedRemote com Radio ---");
        advRemoteForRadio.TogglePower();
        advRemoteForRadio.VolumeUp();
        advRemoteForRadio.VolumeUp();
        advRemoteForRadio.Mute();
        advRemoteForRadio.ChannelUp();


        Console.WriteLine();

        Console.WriteLine("--- Troca dinâmica: AdvancedRemote controla a TV agora ---");
        AdvancedRemote advRemoteForTv = new AdvancedRemote(tv);
        advRemoteForTv.TogglePower();
        advRemoteForTv.VolumeUp();
        advRemoteForTv.ChannelUp();


        Console.WriteLine("\nFim do demo. Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}