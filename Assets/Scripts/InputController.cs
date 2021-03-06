﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script handles all the input controller
public class InputController : MonoBehaviour
{
    [HideInInspector]
    public bool LeftClick;
    [HideInInspector]
    public bool Interact;
    [HideInInspector]
    public bool Map;

    void Update()
    {
        LeftClick = Input.GetMouseButtonDown(0);
        Interact = Input.GetKeyDown(KeyCode.E);
        Map = Input.GetKeyDown(KeyCode.M);
    }


}
