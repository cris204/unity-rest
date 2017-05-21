using UnityEngine;
using UnityRest;

public class Test : MonoBehaviour 
{
	private UnityRestManager api;
	public static Test instance;
	private void Start ()
	{
		instance = this;
		api = UnityRestManager.Instance;
	}

	private void Update () 
	{
		if (Input.GetKeyDown (KeyCode.G))
			GetAll ();
		if (Input.GetKeyDown (KeyCode.O))
			GetOne ();
		if (Input.GetKeyDown (KeyCode.P))
			Post ();
	}

	public void GetAll ()
	{
		api.Get<Post> ().OnResult<Post> (LogAll).Send ();
	}

	public void GetTeam()
	{
		api.Get<Team>().OnResult<Team> (LogAllTeam).Send();
	}
	
	private void LogAllTeam (Team[] teams)
	{
		foreach (Team team in teams)
			LogTeam (team);
	}

	public void GetOne ()
	{
		api.Get<Post> ().OnResult<Post> (Log).WithId ("1").Send ();
	}

	private void LogAll (Post[] posts)
	{
		foreach (Post post in posts)
			Log (post);
	}

	private void LogTeam (Team team)
	{
		Debug.Log (team);
	}

	private void Log (Post post)
	{
		Debug.Log (post.title);
	}	

	private void Post ()
	{
		Post post = new Post ("1", "Hello", "world", 5);
		api.Post<Post> ().WithBody (post).OnResult (LogOk).Send ();
	}

	public void PosteameEsta (int characterId1, int characterId2, int characterId3, int playerId)
	{
		Team team = new Team (characterId1,characterId2,characterId3,playerId);
		api.Post<Team> ().WithBody<Team>(team).OnResult (LogOk).Send ();
	}

	private void LogOk ()
	{
		Debug.Log ("Ok");
	}
}
