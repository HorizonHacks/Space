using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class EarthSize : MonoBehaviour
{
    public InputField InputField1;
    public float radius = 100f; 
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3 (radius*2,radius*2,radius*2);
        transform.position = new Vector3 (0,radius,0);
        InputField1.text = "100";
    }

    void Update()
    {   
        float radius = float.Parse(InputField1.text);
        transform.localScale = new Vector3 (radius*2,radius*2,radius*2);
        transform.position = new Vector3 (transform.position.x,radius,transform.position.z);
    }
}
