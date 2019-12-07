using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AvorionXMLToSTL
{
	class Program
	{
		static async Task Main(string[] args)
		{
			XmlSerializer mySerializer = new XmlSerializer(typeof(object));
			FileStream myFileStream = new FileStream("C:\\Users\\Ian-A\\AppData\\Roaming\\Avorion\\ships\\Prints\\testbench.xml", FileMode.Open);
			object myObject = mySerializer.Deserialize(myFileStream);
		}

		
	}
}
