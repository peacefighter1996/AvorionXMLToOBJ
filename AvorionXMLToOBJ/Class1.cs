using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace AvorionXMLToSTL
{
	public class Solid
	{
		public Solid(List<Face> faces, List<Vector3> vectors)
		{
			Faces = faces;
			Vectors = vectors;
		}
		List<Face> Faces { get; set; }

		List<Vector3> Vectors { get; set; }

		public override string ToString()
		{
			List<int> vectorIndexs = new List<int>();
			StringBuilder stringBuilderFaces = new StringBuilder();
			foreach (var face in Faces)
			{
				foreach (var vector in face.vectors)
				{
					vectorIndexs.Add(Vectors.FindIndex(o => o.X == vector.X && o.Y == vector.Y && o.Z == vector.Z));
				}
				string tempstring = $"f ";
				int k = 0;
				foreach (var item in vectorIndexs)
				{
					tempstring += $"{item + 1}/{k++ +1} ";
				}
				stringBuilderFaces.AppendLine(tempstring);
				vectorIndexs.Clear();
			}
			StringBuilder stringBuilderVector = new StringBuilder();
			foreach (var vector in Vectors)
			{
				stringBuilderVector.AppendLine($"v {vector.X} {vector.Y} {vector.Z}");
			}
			stringBuilderVector.AppendLine("vt 0.000000 1.000000");
			stringBuilderVector.AppendLine("vt 0.000000 0.000000");
			stringBuilderVector.AppendLine("vt 1.000000 0.000000");
			stringBuilderVector.AppendLine("vt 1.000000 1.000000");
			stringBuilderVector.Append(stringBuilderFaces);
			return stringBuilderVector.ToString();
		}
		public void Merge(Solid solid)
		{
			Vectors.AddRange(solid.Vectors);
			Faces.AddRange(solid.Faces);
		}
	}
	public class Face
	{
		public List<Vector3> vectors { get; set; }

	}
}
