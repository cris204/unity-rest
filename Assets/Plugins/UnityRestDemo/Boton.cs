using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRest;

public class Boton : MonoBehaviour {

	public int characterId1;
	public int characterId2;
	public int characterId3;
	public int playerId;
	
	public void SendFinal()
	{
		Test.instance.PosteameEsta(characterId1,characterId2,characterId3,playerId);
	}
}
