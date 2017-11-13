﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

	[SerializeField]
	Map map;
	[SerializeField]
	Unit KingPrefab;
	[SerializeField]
	Unit EnemyKingPrefab;

	// Use this for initialization
	IEnumerator Start () {
		map.GenerateMap();
		yield return null;

		KingPrefab.gameObject.SetActive(false);
		EnemyKingPrefab.gameObject.SetActive(false);

		map.PutUnit (0, 4, KingPrefab, false);
		//map.PutUnit ();
		//map.PutUnit ();
		//map.PutUnit ();

		map.PutUnit (19, 4, EnemyKingPrefab, true);
		//map.PutUnit ();
		//map.PutUnit ();
		//map.PutUnit ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
