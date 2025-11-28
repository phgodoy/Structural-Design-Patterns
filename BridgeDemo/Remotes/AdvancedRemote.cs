using BridgeDemo.Devices.Interfaces;

namespace BridgeDemo.Remotes
{
    public class AdvancedRemote : RemoteControl
    {
        public AdvancedRemote(IDevice device) : base(device) { }

        public void Mute()
        {
            _device.SetVolume(0);
            Console.WriteLine("Dispositivo silenciado (mute).");
        }
    }
}
