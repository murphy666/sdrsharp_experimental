using SDRSharp.Radio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDRSharp.DNR
{
    public interface INoiseProcessor : IBaseProcessor
    {
        int NoiseThreshold { get; set; }
    }
}
