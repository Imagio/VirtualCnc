using System.Xml.Serialization;

namespace VirtualCnc.Configuration {
	[XmlType("channel")]
	public class ChannelConfiguration
	{
		[XmlAttribute("name")]
		public string Name { get; set; }
		
		[XmlArray("axes")]
		public AxisConfiguration[] Axes { get; set; }
		
		[XmlArray("spindles")]
		public SpindleConfiguration[] Spindles { get; set; }
	}
}