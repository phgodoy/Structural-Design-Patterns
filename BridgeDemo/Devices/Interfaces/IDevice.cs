using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDemo.Devices.Interfaces
{
    public interface IDevice
    {
        bool IsEnabled { get; }
        int Volume { get; }
        int Channel { get; }


        void Enable();
        void Disable();
        void SetVolume(int percent);
        void SetChannel(int channel);
    }
}
