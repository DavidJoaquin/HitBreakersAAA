﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFijarRotacion2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.rotation = Quaternion.Euler(Vector3.zero);

    }
}
