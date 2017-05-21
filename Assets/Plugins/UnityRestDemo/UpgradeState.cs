using System;
using System.ComponentModel;
using System.Collections.Generic;

[Serializable]
[Description ("unlock_character")]
public class UpgradeState 
{
	public string statToUpgrade;
	public int playerId;
	public int characterId;

	public UpgradeState (string statToUpgrade, int playerId, int characterId)
	{
		this.statToUpgrade = statToUpgrade;
		this.playerId = playerId;
		this.characterId = characterId;
	}
}
