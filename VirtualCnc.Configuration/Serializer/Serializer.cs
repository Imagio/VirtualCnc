using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace VirtualCnc.Configuration
{
	public class Serializer<T>
	{
		public string Serialize(T configuration)
		{
			var serializer = new XmlSerializer(typeof(T));
			
			var settings = new XmlWriterSettings {
				Encoding = new UnicodeEncoding(false, false),
				Indent = true,
				OmitXmlDeclaration = true,
				CheckCharacters = false,
			};

			using (var textWriter = new StringWriter()) {
				using (var xmlWriter = XmlWriter.Create(textWriter, settings)) {
					serializer.Serialize(xmlWriter, configuration);
				}
				return textWriter.ToString();
			}
		}

		public T Deserialize(string xml)
		{
			var byteOrderMark = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble()).ToCharArray();
			xml = xml.Trim().Trim(byteOrderMark).Trim();

			var settings = new XmlReaderSettings {CheckCharacters = false};

			using (TextReader reader = new StringReader(xml)) {
				using (var xmlReader = XmlReader.Create(reader, settings)) {
					var serializer = new XmlSerializer(typeof(T));
					return (T)serializer.Deserialize(xmlReader);
				}
			}
		}
	}
}