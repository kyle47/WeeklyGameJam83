﻿using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{
    public Trap[] Traps;

    public void Activate(int mode)
    {
        Traps[mode].Activate();
    }
}