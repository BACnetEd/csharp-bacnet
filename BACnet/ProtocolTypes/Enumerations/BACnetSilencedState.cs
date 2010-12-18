using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using BACnet.Converters;

namespace BACnet.ProtocolTypes
{
    [TypeConverter(typeof(EnumTypeConverter<BACnetSilencedState>))]
	public enum BACnetSilencedState
	{
		Unsilenced = 0,
		AudibleSilenced = 1,
		VisibileSilenced = 2,
		AllSilenced = 3
	}
}
