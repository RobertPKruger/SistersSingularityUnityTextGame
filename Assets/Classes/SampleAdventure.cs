using System;
using System.Collections.Generic;

public class SampleAdventure
{
	public SampleAdventure()
	{
		Locations = GetLocations();
	}

	public List<LocationState> Locations
	{
		get;set;
	}
	
	private List<LocationState> GetLocations(){

			var state1 = new LocationState();
			state1.AdjacentLocations = new List<string> { "forest", "porch", "backyard" };
			state1.Name = "front yard";
			state1.Description = "You have been traveling in a strange country and after a day in the wilderness you come upon an old, forbidding house in a clearing. You are hungry, and a storm is approaching. Do you shelter in the woods, go up to the front porch and try the door, or sneak around to the rear of the house?";
			state1.Help = "This house is offering you shelter from the storm. Maybe you should go inside.";


			var state2 = new LocationState();
			state2.AdjacentLocations = new List<string> { "front yard" };
			state2.Name = "forest";
			state2.Description = "You are in a forest. There is a corpse.";

			var state3 = new LocationState();
			state3.AdjacentLocations = new List<string> { "front yard" };
			state3.Name = "backyard";
			state3.Description = "You are in a backyard.";

			var state4 = new LocationState();
			state4.AdjacentLocations = new List<string> { "front yard","foyer" };
			state4.Name = "porch";
			state4.Description = "You are on a porch. The door to the house is locked. ";
			state4.Help = "You should try the door.";

			var state5 = new LocationState();
			state5.AdjacentLocations = new List<string> { "parlor", "porch" };
			state5.Name = "foyer";
			state5.Description = "You are in the foyer of the house. The door to the outside is open behind you.";
			state5.Help = "You have a bad feeling about this place.";

			var state6 = new LocationState();
			state6.AdjacentLocations = new List<string> { "foyer" };
			state6.Name = "parlor";
			state6.Description = "You are in the parlor of the house. There is a merchant here. He says, \"Hello, want to sell me something?\"";
			state6.Help = "THE REST OF THE GAME HAS NOT BEEN MADE YET";

			var locations = new List<LocationState> { state1,state2,state3,state4,state5,state6};

			return locations;
		}
	


}
