using System;
using System.Collections.Generic;

namespace interfaces
{
	public interface IAdventure
	{
		ILocationState CurrentState { get; set; }
		void ChangeState(string stateName);
	}
}