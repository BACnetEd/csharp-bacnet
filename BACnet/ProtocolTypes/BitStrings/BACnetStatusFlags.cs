using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BACnet.ProtocolTypes
{
    public enum BACnetStatusFlags
    {
        InAlarm = 0,
        Fault = 1,
        Overriden = 2,
        OutOfService = 3
    }
}
