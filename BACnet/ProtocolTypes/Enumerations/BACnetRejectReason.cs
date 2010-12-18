/*  BACnetRejectReason Enumeration
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
	public enum BACnetRejectReason
	{
		Other = 0,
		BufferOverflow = 1,
		InconsistentParameters = 2,
		InvalidParameterDataType = 3,
		InvalidTag = 4,
		MissingRequiredParameter = 5,
		ParameterOutOfRange = 6,
		TooManyArguments = 7,
		UndefinedEnumeration = 8,
		UnrecognizedService = 9
	}
}
