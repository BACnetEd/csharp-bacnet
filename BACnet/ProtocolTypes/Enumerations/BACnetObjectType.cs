﻿/*  BACnetObjectType Enumeration
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
	public enum BACnetObjectType
	{
		AccessDoor = 30,
		Accumulator = 23,
		AnalogInput = 0,
		AnalogOutput = 1,
		AnalogValue = 2,
		Averaging = 18,
		BinaryInput = 3,
		BinaryOutput = 4,
		BinaryValue = 5,
		Calendar = 6,
		Command = 7,
		Device = 8,
		EventEnrollment = 9,
		EventLog = 25,
		File = 10,
		Group = 11,
		LifeSafetyPoint = 21,
		LifeSafetyZone = 22,
		LoadControl = 28,
		Loop = 12,
		MultiStateInput = 13,
		MultiStateOutput = 14,
		MultiStateValue = 19,
		NotificationClass = 15,
		Program = 16,
		PulseConverter = 24,
		Schedule = 17,
		StructuredView = 29,
		TrendLog = 20,
		TrendLogMultiple = 27
	}
}
