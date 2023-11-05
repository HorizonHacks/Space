using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public InputField InputField;
    public InputField InputField1; //size
    public int distance = 5;
    public float radius = 100f; 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (0,radius,500);
        InputField.text = "0";
        InputField1.text = "100";
    }

    // Update is called once per frame
    void Update()
    {
        float radius = float.Parse(InputField1.text);
        int distance = int.Parse(InputField.text);
        transform.position = new Vector3 (0,radius,500+distance);
        transform.localScale = new Vector3 (radius*2,radius*2,radius*2);
        transform.position = new Vector3 (transform.position.x,radius,transform.position.z);
    }
}
