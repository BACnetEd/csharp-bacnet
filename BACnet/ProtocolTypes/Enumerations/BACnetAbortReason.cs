using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using BACnet.Converters;

namespace BACnet.Enumerations
{
    [TypeConverter(typeof(EnumTypeConverter<BACnetAbortReason>))]
	public enum BACnetAbortReason
	{
		Other = 0,
		BufferOverflow = 1,
		InvalidApduInThisState = 2,
		PreemptedByHigherPriorityTask = 3,
		SegmentationNotSupported = 4
	}
}
