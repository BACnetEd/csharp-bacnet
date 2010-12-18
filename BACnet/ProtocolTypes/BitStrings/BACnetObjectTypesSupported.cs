using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BACnet.ProtocolTypes
{
    public enum BACnetObjectTypesSupported
    {
        AnalogInput = 0,
        AnalogOutput = 1,
        AnalogValue = 2,
        BinaryInput = 3,
        BinaryOutput = 4,
        BinaryValue = 5,
        Calendar = 6,
        Command = 7,
        Device = 8,
        EventEnrollment = 9,
        File = 10,
        Group = 11,
        Loop = 12,
        MultiStateInput = 13,
        MultiStateOutput = 14,
        NotificationClass = 15,
        Program = 16,
        Schedule = 17,
        Averaging = 18,
        MultiStateValue = 19,
        TrendLog = 20,
        LifeSafetyPoint = 21,
        LifeSafetyZone = 22,
		Accumulator = 23,
        PulseConverter = 24,
        EventLog = 25,
        TrendLogMultiple = 27,
        LoadControl = 28,
        StructuredView = 29,
		AccessDoor = 30
    }
}
