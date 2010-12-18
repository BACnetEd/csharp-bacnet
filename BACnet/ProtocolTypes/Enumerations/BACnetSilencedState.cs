using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace BACnet.ProtocolTypes
{
	public enum BACnetSilencedState
	{
		Unsilenced = 0,
		AudibleSilenced = 1,
		VisibileSilenced = 2,
		AllSilenced = 3
	}
}
