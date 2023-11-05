using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    private float turnit = .5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(turnit,0,0);
    }
}
