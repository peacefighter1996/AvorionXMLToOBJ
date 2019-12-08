using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AvorionXMLToSTL
{
	class Program
	{

		static async Task Main(string[] args)
		{
			string inputFile = args[0];
			string outputFile = args[1];

			XmlSerializer ShipSerializer = new XmlSerializer(typeof(ship_design));
			FileStream LoadShip = new FileStream(inputFile, FileMode.Open);
			
			ship_design ship = (ship_design)ShipSerializer.Deserialize(LoadShip);
			LoadShip.Close();

			Solid baseSolid = new Solid(new List<Face>(), new List<Vector3>());
			foreach (var item in ship.plan.item)
			{
				if (item.block.CanGenerate)
				{
					baseSolid.Merge(item.block.ToSolid());
				}
			}
			string stringOutput = baseSolid.ToString();

			//Checks if 
			if (!File.Exists(outputFile))
			{
				var stream = File.Create(outputFile);
				stream.Close();
			}
			else
			{
				File.Delete(outputFile);
				var stream = File.Create(outputFile);
				stream.Close();
				
			}
			File.WriteAllText(outputFile, stringOutput);
		}


	}
}
