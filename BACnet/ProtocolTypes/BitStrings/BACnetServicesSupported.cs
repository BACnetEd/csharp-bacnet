using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BACnet.ProtocolTypes
{
    public enum BACnetServicesSupported
    {
        AcknowledgeAlarm = 1,
        ConfirmedCOVNotification = 1,
        ConfirmedeventNOtification = 2,
        GetAlarmSummary = 3,
        GetEnrollmentSummary = 4,
        SubscribeCOV = 5,
        AtomicReadFile = 6,
        AtomicWriteFile = 7,
        AddListElement = 8,
        RemoveListElement = 9,
        CreateObject = 10,
        DeleteObject = 11,
        ReadProperty = 12,
        ReadPropertyConditional = 13,
        ReadPropertyMultiple = 14,
        WriteProperty = 15,
        WritePropertyMultiple = 16,
        DeviceCommunicationControl = 17,
        ConfirmedPrivateTransfer = 18,
        ConfirmedTextMessage = 19,
        ReinitializeDevice = 20,
        VtOpen = 21,
        VtClose = 22,
        VtData = 23,
        Authenticate = 24,
        RequestKey = 25,
        IAm = 26,
        IHave = 27,
        UnconfirmedCOVNotification = 28,
        UnconfirmedEventNotification = 29,
        UnconfirmedPrivateTransfer = 30,
        UnconfirmedTextMessage = 31,
        TimeSynchronization = 32,
        WhoHas = 33,
        WhoIs = 34,
        ReadRange = 35,
        UtcTimeSynchronization = 36,
        LifeSafetyOperation = 37,
        SubscribeCOVProperty = 38,
        GetEventInformation = 39
    }
}
