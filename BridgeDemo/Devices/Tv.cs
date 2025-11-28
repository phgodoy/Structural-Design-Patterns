using BridgeDemo.Devices.Interfaces;

namespace BridgeDemo.Devices
{
    public class Tv : IDevice
    {
        public bool IsEnabled { get; private set; }
        public int Volume { get; private set; }
        public int Channel { get; private set; }


        public void Enable() => IsEnabled = true;
        public void Disable() => IsEnabled = false;
        public void SetVolume(int percent)
        {
            Volume = Math.Clamp(percent, 0, 100);
            Console.WriteLine($"[TV] Volume ajustado para: {Volume}%");
        }
        public void SetChannel(int channel)
        {
            Channel = Math.Max(1, channel);
            Console.WriteLine($"[TV] Canal ajustado para: {Channel}");
        }
    }
}
