using System;
using System.ComponentModel;
using System.Collections.Generic;

[Serializable]
[Description ("match")]
public class Match 
{
	public int winnerId;
	public int winnerNewScore;
	public int losserId;
	public int losserNewScore;

	public Match (int winnerId, int winnerNewScore, int losserId, int losserNewScore)
	{
		this.winnerId = winnerId;
		this.losserId = losserId;
		this.winnerNewScore= winnerNewScore;
		this.losserNewScore = losserNewScore;
	}
}
