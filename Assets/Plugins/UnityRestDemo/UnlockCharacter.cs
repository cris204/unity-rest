using System;
using System.ComponentModel;
using System.Collections.Generic;

[Serializable]
[Description ("unlock_character")]
public class UnlockCharacter 
{
	public int playerId;
	public int characterId;
	public int lifePoints;
	public int attackPoints;
	public int defensePoints;
	public int spAttackPoints;
	public int spDefensePoints;

	public UnlockCharacter (int playerId, int characterId, int lifePoints, int attackPoints, int defensePoints, int spAttackPoints, int spDefensePoints)
	{
		this.playerId = playerId;
		this.characterId = characterId;
		this.lifePoints = lifePoints;
		this.attackPoints = attackPoints;
		this.defensePoints= defensePoints;
		this.spAttackPoints = spAttackPoints;
		this.defensePoints = defensePoints;
	}
}
