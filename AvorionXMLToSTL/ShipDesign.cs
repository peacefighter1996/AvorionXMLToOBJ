using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Serialization;
namespace AvorionXMLToSTL
{
	// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class ship_design
	{

		private ship_designPlan planField;

		/// <remarks/>
		public ship_designPlan plan
		{
			get
			{
				return this.planField;
			}
			set
			{
				this.planField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ship_designPlan
	{

		private ship_designPlanItem[] itemField;

		private bool accumulateHealthField;

		private bool convexField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("item")]
		public ship_designPlanItem[] item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool accumulateHealth
		{
			get
			{
				return this.accumulateHealthField;
			}
			set
			{
				this.accumulateHealthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public bool convex
		{
			get
			{
				return this.convexField;
			}
			set
			{
				this.convexField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ship_designPlanItem
	{

		private ship_designPlanItemBlock blockField;

		private int parentField;

		private uint indexField;

		/// <remarks/>
		public ship_designPlanItemBlock block
		{
			get
			{
				return this.blockField;
			}
			set
			{
				this.blockField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int parent
		{
			get
			{
				return this.parentField;
			}
			set
			{
				this.parentField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public uint index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;
			}
		}
	}

	/// <remarks/>
	[System.SerializableAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class ship_designPlanItemBlock
	{

		private decimal lxField;

		private decimal lyField;

		private decimal lzField;

		private decimal uxField;

		private decimal uyField;

		private decimal uzField;

		private byte indexField;

		private byte materialField;

		private int lookField;

		private int upField;

		private string colorField;
		private ISolidGenrator solidGenrator;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal lx
		{
			get
			{
				return this.lxField;
			}
			set
			{
				this.lxField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal ly
		{
			get
			{
				return this.lyField;
			}
			set
			{
				this.lyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal lz
		{
			get
			{
				return this.lzField;
			}
			set
			{
				this.lzField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal ux
		{
			get
			{
				return this.uxField;
			}
			set
			{
				this.uxField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal uy
		{
			get
			{
				return this.uyField;
			}
			set
			{
				this.uyField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public decimal uz
		{
			get
			{
				return this.uzField;
			}
			set
			{
				this.uzField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte index
		{
			get
			{
				return this.indexField;
			}
			set
			{
				this.indexField = value;

				switch (value)
				{
					case 1: // Cube hull
					case 8: // Armored hull
						solidGenrator = new Cube();
						break;

					case 100:
						solidGenrator = new Angle();
						break;
					default:
						Console.WriteLine("Unable to find Generator gor this Type");
						break;

				}
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public byte material
		{
			get
			{
				return this.materialField;
			}
			set
			{
				this.materialField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int look
		{
			get
			{
				return this.lookField;
			}
			set
			{
				this.lookField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public int up
		{
			get
			{
				return this.upField;
			}
			set
			{
				this.upField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}
		public bool CanGenerate
		{
			get
			{
				return solidGenrator != null;
			}
		}
		public Solid ToSolid()
		{
			return solidGenrator.GetSolid(this);
		}
	}

	public interface ISolidGenrator
	{
		Solid GetSolid(ship_designPlanItemBlock block);
	}
	public class Cube : ISolidGenrator
	{
		public Solid GetSolid(ship_designPlanItemBlock block)
		{
			List<Vector3> vectors = new List<Vector3>();
			for (int i = 0; i < 8; i++)
			{
				var array = new Vector3()
				{
					X = (i & 0b_0001) == 0 ? (float)block.lx : (float)block.ux,
					Y = (i & 0b_0010) == 0 ? (float)block.ly : (float)block.uy,
					Z = (i & 0b_0100) == 0 ? (float)block.lz : (float)block.uz
				};
				vectors.Add(array);
			}

			List<Face> faces = new List<Face>();

			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[3], vectors[2] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[5], vectors[4] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[1], vectors[3], vectors[7], vectors[5] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[2], vectors[3], vectors[7], vectors[6] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[0], vectors[2], vectors[6], vectors[4] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[4], vectors[5], vectors[7], vectors[6] } });
			return new Solid(faces, vectors);
		}
	}
	public class Angle : ISolidGenrator
	{
		public Solid GetSolid(ship_designPlanItemBlock block)
		{
			List<Vector3> vectors = new List<Vector3>();
			Vector3 sum = new Vector3();
			for (int i = 0; i < 8; i++)
			{
				var array = new Vector3()
				{
					X = (i & 0b_0001) == 0 ? (float)block.lx : (float)block.ux,
					Y = (i & 0b_0010) == 0 ? (float)block.ly : (float)block.uy,
					Z = (i & 0b_0100) == 0 ? (float)block.lz : (float)block.uz
				};
				vectors.Add(array);
				sum += array;
			}
			Vector3 avarage = sum / 8;
			List<Face> faces = new List<Face>();
			switch (block.look)
			{
				case 0: //face 3 look
					switch (block.up)
					{
						case 2:
							faces = Face13(vectors);
							break;
						case 3:
							faces = Face34(vectors);
							break;
						case 4:
							faces = Face03(vectors);
							break;
						case 5:
							faces = Face35(vectors);
							break;
						default:
							Console.WriteLine($"Missing: look:{block.look} up:{block.up}");
							vectors.Clear();
							break;
					}
					break;
				case 1: //face 2 look
					switch (block.up)
					{
						case 2:
							faces = Face12(vectors);
							break;
						case 3:
							faces = Face24(vectors);
							break;
						case 4:
							faces = Face02(vectors);
							break;
						case 5:
							faces = Face25(vectors);
							break;
						default:
							Console.WriteLine($"Missing: look:{block.look} up:{block.up}");
							vectors.Clear();
							break;
					}
					break;
				case 2: //face 4 look
					switch (block.up)
					{
						case 0:
							faces = Face24(vectors);
							break;
						case 1:
							faces = Face34(vectors);
							break;
						case 4:
							faces = Face04(vectors);
							break;
						case 5:
							faces = Face45(vectors);
							break;
						default:
							Console.WriteLine($"Missing: look:{block.look} up:{block.up}");
							vectors.Clear();
							break;
					}
					break;

				case 3: //face 1 look
					switch (block.up)
					{
						
						case 0:
							faces = Face12(vectors);
							break;
						case 1:
							faces = Face13(vectors);
							break;
						case 4:
							faces = Face01(vectors);
							break;
						case 5:
							faces = Face15(vectors);
							break;
						default:
							Console.WriteLine($"Missing: look:{block.look} up:{block.up}");
							vectors.Clear();
							break;
					}
					break;
				case 4: // face 5 look
					switch (block.up)
					{
						case 0:
							faces = Face25(vectors);
							break; 
						case 1:
							faces = Face35(vectors);
							break;
						case 3:
							faces = Face45(vectors);
							break;
						case 2:
							faces = Face15(vectors);
							break;
						default:
							Console.WriteLine($"Missing: look:{block.look} up:{block.up}");
							vectors.Clear();
							break;
					}
					break;

				case 5: //face 0 look
					switch (block.up)
					{

						case 0:
							faces = Face02(vectors);
							break;
						case 1:
							faces = Face03(vectors);
							break;
						case 2:
							faces = Face01(vectors);
							break;
						case 3:
							faces = Face04(vectors);

							break;
						default:
							Console.WriteLine($"Missing: look:{block.look} up:{block.up}");
							vectors.Clear();
							break;
					}
					break;
				default:
					Console.WriteLine($"Missing look:{block.look}");
					vectors.Clear();
					break;
			}
			/*
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[3], vectors[2] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[5], vectors[4] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[1], vectors[3], vectors[5] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[2], vectors[0], vectors[4] } });
			faces.Add(new Face() { vectors = new List<Vector3>() { vectors[2], vectors[3], vectors[5], vectors[4] } });*/
			return new Solid(faces, vectors);
		}

		private static List<Face> Face34(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[5], vectors[6], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[4], vectors[6], vectors[2], vectors[0] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[0], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[6], vectors[5], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[5], vectors[4], vectors[0], vectors[1] } }
			};
		}

		private static List<Face> Face24(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[5], vectors[7], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[4], vectors[7], vectors[3], vectors[0] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[0], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[7], vectors[5], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[5], vectors[4], vectors[0], vectors[1] } }
			};
		}
		private static List<Face> Face12(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[5], vectors[7], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[6], vectors[7], vectors[3], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[2], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[7], vectors[5], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[5], vectors[6], vectors[2], vectors[1] } }
			};
		}

		private static List<Face> Face13(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[4], vectors[7], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[6], vectors[7], vectors[3], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[2], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[7], vectors[4], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[4], vectors[6], vectors[2], vectors[0] } }
			};
		}

		private static List<Face> Face45(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[3], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[5], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[3], vectors[5] } },
				new Face() { vectors = new List<Vector3>() { vectors[2], vectors[0], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[2], vectors[3], vectors[5], vectors[4] } }
			};
		}
		private static List<Face> Face15(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[3], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[7], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[3], vectors[7] } },
				new Face() { vectors = new List<Vector3>() { vectors[2], vectors[0], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[2], vectors[3], vectors[7], vectors[6] } }
			};
		}
		private static List<Face> Face01(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[6], vectors[7], vectors[3], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[6], vectors[7], vectors[5], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[7], vectors[3], vectors[5] } },
				new Face() { vectors = new List<Vector3>() { vectors[2], vectors[6], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[2], vectors[3], vectors[5], vectors[4] } }
			};
		}
		private static List<Face> Face02(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[4], vectors[5], vectors[7], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[5], vectors[7], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[7], vectors[3], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[5], vectors[1], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[3], vectors[6], vectors[4] } }
			};
		}
		private static List<Face> Face03(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[4], vectors[5], vectors[7], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[5], vectors[7], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[7], vectors[2], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[5], vectors[0], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[2], vectors[6], vectors[4] } }
			};
		}
		private static List<Face> Face04(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[7], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[5], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[7], vectors[5] } },
				new Face() { vectors = new List<Vector3>() { vectors[6], vectors[0], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[6], vectors[7], vectors[5], vectors[4] } }
			};
		}
		private static List<Face> Face25(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[5], vectors[7], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[5], vectors[7], vectors[3] } },
				new Face() { vectors = new List<Vector3>() { vectors[7], vectors[3], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[5], vectors[1], vectors[0] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[3], vectors[2], vectors[0] } }
			};
		}
		private static List<Face> Face35(List<Vector3> vectors)
		{
			return new List<Face>() {
				new Face() { vectors = new List<Vector3>() { vectors[4], vectors[1], vectors[3], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[1], vectors[3], vectors[2] } },
				new Face() { vectors = new List<Vector3>() { vectors[3], vectors[2], vectors[6] } },
				new Face() { vectors = new List<Vector3>() { vectors[1], vectors[0], vectors[4] } },
				new Face() { vectors = new List<Vector3>() { vectors[0], vectors[2], vectors[6], vectors[4] } }
			};
		}
	}

	/*
	 *<?xml version="1.0" encoding="utf-8"?>
<ship_design>
	<plan accumulateHealth="true" convex="false">
		<item parent="-1" index="0">
			<block lx="-1" ly="-1" lz="-1" ux="1" uy="1" uz="1" index="1" material="0" look="1" up="3" color="ffbfaea3"/>
		</item>
		<item parent="0" index="1">
			<block lx="-0.5" ly="-0.5" lz="1" ux="0.5" uy="0.5" uz="2" index="1" material="0" look="1" up="3" color="ffbfaea3"/>
		</item>
		<item parent="1" index="2">
			<block lx="-1" ly="-1" lz="2" ux="1" uy="1" uz="4" index="1" material="0" look="1" up="3" color="ffbfaea3"/>
		</item>
		<item parent="2" index="3">
			<block lx="-0.25" ly="-0.25" lz="4" ux="0.25" uy="0.25" uz="4.5" index="1" material="0" look="1" up="3" color="ffbfaea3"/>
		</item>
		<item parent="0" index="4">
			<block lx="-0.5" ly="1" lz="-0.5" ux="0.5" uy="2" uz="0.5" index="100" material="0" look="5" up="3" color="ffbfaea3"/>
		</item>
		<item parent="2" index="5">
			<block lx="-1" ly="1" lz="2" ux="1" uy="3" uz="4" index="101" material="0" look="5" up="3" color="ffbfaea3"/>
		</item>
	</plan>
</ship_design>
	 */
}
