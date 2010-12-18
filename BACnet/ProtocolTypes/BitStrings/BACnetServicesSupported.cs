/*  BACnetServicesSupported BitString
 *  Copyright (C) 2010 Loren Van Spronsen
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

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
