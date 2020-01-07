using UnityEngine;
using UnityEditor;
using interfaces;
using System.Collections.Generic;

public class LocationState : ILocationState
{
	public List<string> AdjacentLocations { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string Help { get; set; }
}