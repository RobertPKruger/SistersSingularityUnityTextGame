using System;
using System.Collections.Generic;

namespace interfaces
{
	public interface ILocationState
	{
		List<string> AdjacentLocations { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		string Help { get; set; }
	}
}