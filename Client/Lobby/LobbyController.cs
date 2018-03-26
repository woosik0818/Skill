﻿using UnityEngine;
using System.Collections;

public class LobbyController : MonoBehaviour 
{
	public GameObject rankContent;

	// Use this for initialization
	void Start () 
    {
		Screen.SetResolution(1280, 720, true); 
		RankCellPool.Instance.Init ();
	}
	
	public void GoGame()
	{
		Application.LoadLevel("02.SlimeMap");
	}

	public void GoRank()
	{	
		rankContent.SetActive (true);
		rankContent.GetComponentInChildren<RankContent>().LoadRankList ();
	}

	public void CloseRank()
	{
		rankContent.SetActive (false);
	}

	public void ClickDiaPlus()
	{
		NotificationCenter.Instance.Notify (NotificationCenter.Subject.ClickDiaPlus);
	}
}
