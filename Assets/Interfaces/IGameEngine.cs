using System;

public interface IGameEngine
{
	void HandleUpdate();
	string CharacterLabel { get; set; }
}