using System.Xml.Serialization;

namespace VirtualCnc.Configuration {
	[XmlType("spindle")]
	public class SpindleConfiguration
	{
		[XmlAttribute("name")]
		public string Name { get; set; }
	}
}