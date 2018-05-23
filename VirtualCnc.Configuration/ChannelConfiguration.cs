using System.Xml.Serialization;

namespace VirtualCnc.Configuration {
	[XmlType("channel")]
	public class ChannelConfiguration
	{
		[XmlAttribute("name")]
		public string Name { get; set; }
	}
}