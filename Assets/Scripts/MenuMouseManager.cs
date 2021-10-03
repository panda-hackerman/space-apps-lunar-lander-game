﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMouseManager : MonoBehaviour
{
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}