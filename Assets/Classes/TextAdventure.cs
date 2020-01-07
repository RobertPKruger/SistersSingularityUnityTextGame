using System;
using System.Collections.Generic;
using interfaces;

public class TextAdventure : IAdventure
{
	public TextAdventure(List<LocationState> locations)
	{
		this.Locations = locations;
		this.Initialize();
	}

	private void Initialize() {
		if (Locations.Count > 0)
		{
			CurrentState = Locations[0];
		}
	}

	public List<LocationState> Locations { get; set; }
	public ILocationState CurrentState { get; set; }

	public void ChangeState(string stateName)
	{
		if (this.CurrentState.Name == stateName)
			return;

		var newState = this.Locations.Find(l => l.Name == stateName);
		this.CurrentState = newState;
	}
}