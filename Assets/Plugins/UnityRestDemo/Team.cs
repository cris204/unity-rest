using System;
using System.ComponentModel;
using System.Collections.Generic;

[Serializable]
[Description ("team")]
public class Team 
{
	public int characterId_1;
	public int characterId_2;
	public int characterId_3;
	public int playerId;

	public Team (int characterId_1, int characterId_2, int characterId_3, int playerId)
	{
		this.characterId_1 = characterId_1;
		this.characterId_2 = characterId_2;
		this.characterId_3 = characterId_3;
		this.playerId = playerId;
	}
}
