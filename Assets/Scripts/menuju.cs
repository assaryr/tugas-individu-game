﻿using UnityEngine;
using System.Collections;

public class menuju : MonoBehaviour {
	
	//Use this for initialization
	void Start () {
	
	}
	
	// update is called once per frame
	void Update () {
	
	}
	
	public void ketujuan(int yangdituju){
		Application.LoadLevel (yangdituju);
	}
}