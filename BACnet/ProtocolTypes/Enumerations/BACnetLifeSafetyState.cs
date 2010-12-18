/*  BACnetLifeSafetyState Enumeration
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
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BACnet.ProtocolTypes
{
    public enum BACnetLifeSafetyState
    {
        Quiet = 0,
        PreAlarm = 1,
        Alarm = 2,
        Fault = 3,
        FaultPreAlarm = 4,
        FaultAlarm = 5,
        NotReady = 6,
        Active = 7,
        Tamper = 8,
        TestAlarm = 9,
        TestActive = 10,
        TestFault = 11,
        TestFaultAlarm = 12,
        Holdup = 13,
        Duress = 14,
        TamperAlarm = 15,
        Abnormal = 16,
        EmergencyPower = 17,
        Delayed = 18,
        Blocked = 19,
        LocalAlarm = 20,
        GeneralAlarm = 21,
        Supervisory = 22,
        TestSupervisory = 23
    }
}
