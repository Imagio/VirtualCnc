using System.Xml.Serialization;

namespace VirtualCnc.Configuration
{
	[XmlRoot("root")]
	public class CncConfiguration
	{
		[XmlArray("channels")]
		public ChannelConfiguration[] Channels { get; set; }
	}
}