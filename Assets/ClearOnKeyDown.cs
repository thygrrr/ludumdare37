﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearOnKeyDown : MonoBehaviour
{

	// Update is called once per frame
	void Update ()
	{
		if (Input.anyKey)
		{
			Object.Destroy(gameObject);
		}
		
	}
}
