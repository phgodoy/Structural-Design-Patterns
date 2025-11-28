using BridgeDemo.Devices.Interfaces;

namespace BridgeDemo.Remotes
{
    public class RemoteControl
    {
        protected IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public virtual void TogglePower()
        {
            if (_device.IsEnabled)
            {
                _device.Disable();
                Console.WriteLine("Dispositivo desligado.");
            }
            else
            {
                _device.Enable();
                Console.WriteLine("Dispositivo ligado.");
            }
        }

        public virtual void VolumeDown()
        {
            _device.SetVolume(Math.Max(0, _device.Volume - 10));
        }


        public virtual void VolumeUp()
        {
            _device.SetVolume(Math.Min(100, _device.Volume + 10));
        }


        public virtual void ChannelUp()
        {
            _device.SetChannel(_device.Channel + 1);
        }


        public virtual void ChannelDown()
        {
            _device.SetChannel(Math.Max(1, _device.Channel - 1));
        }
    }
}
