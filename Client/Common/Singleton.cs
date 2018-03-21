﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Singleton : MonoBehaviour {

	//public string HOST = "http://ec2-52-197-102-179.ap-northeast-1.compute.amazonaws.com";
	public string HOST = "http://skill-server.azurewebsites.net";

	//Singleton Member And Method
	static Singleton _instance;
	public static Singleton Instance {
		get {
			if( ! _instance ) {
				GameObject container = new GameObject("Singleton");
				_instance = container.AddComponent( typeof( Singleton ) ) as Singleton;
				DontDestroyOnLoad( container );
			}
			
			return _instance;
		}
	}
}
