using System.Xml.Serialization;

namespace VirtualCnc.Configuration {
	[XmlType("axis")]
	public class AxisConfiguration
	{
		[XmlAttribute("name")]
		public string Name { get; set; }
	}
}