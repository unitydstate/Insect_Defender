﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour {

	public void OnMouseDown()
    {
        transform.localScale *= 0.9F;
        Application.Quit();
    }
}
