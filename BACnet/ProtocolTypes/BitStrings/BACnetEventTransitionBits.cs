using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BACnet.ProtocolTypes
{
    public enum BACnetEventTransitionBits
    {
        ToOffnormal = 0,
        ToFault = 1,
        ToNormal = 2
    }
}
