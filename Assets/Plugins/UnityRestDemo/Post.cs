﻿using System;
using System.ComponentModel;

[Serializable]
[Description ("posts")]
public class Post 
{
	public string body;
	public string userId;
	public int id;
	public string title;
	

	public Post (string userId, string title, string body, int id)
	{
		this.userId = userId;
		this.title = title;
		this.body = body;
		this.id = id;
	}

	public override string ToString ()
	{
		return string.Format ("{0} - {1}:{2}\n{3}", title, userId, id, body);
	}
}
