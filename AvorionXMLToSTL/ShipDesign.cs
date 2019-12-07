using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
namespace AvorionXMLToSTL
{
	[Serializable()]
	[XmlRoot("ShipDesignCollection")]
	class ShipDesign
	{
		[XmlElement("ship_design")]
		Plan plan {get;set;}
	}
	[Serializable()]
	class Plan
	{
		[XmlArray("Items")]
		[XmlArrayItem("item",type: typeof(Item))]
		List<Item> items { get; set; }

		[XmlAttribute("accumulateHealth")]
		bool accumulateHealth { get; set; }

	}

	[Serializable()]
	public class Item
	{

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
