﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class RobotPlaneInput : MonoBehaviour
{
    [SerializeField] private PlaneController plane;

    // Start is called before the first frame update
    void Start()
    {
        plane.SetThrottle(1f);
    }

    // Update is called once per frame
    void Update()
    {
        // Pitch
        if (plane.Pitch < 14)
        {
            plane.SetElevatorAmount(1);
        }
        else if (plane.Pitch > 18)
        {
            plane.SetElevatorAmount(-1);
        } 
        else
        {
            plane.SetElevatorAmount(0);
        }

        //Roll
        if (plane.Roll > 25)
        {
            plane.SetAileronAmount(1);
        } 
        else if (plane.Roll < -25)
        {
            plane.SetAileronAmount(-1);
        }
        else
        {
            plane.SetAileronAmount(0);
        }
    }
}
