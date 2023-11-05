using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class Rotation : MonoBehaviour
{
    private float spin = .5f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,spin,0);
    }
}
