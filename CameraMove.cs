using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class CameraMove : MonoBehaviour
{
    public InputField InputField;
    public InputField InputField1; // radius of earth
    public InputField InputField2; // radius of second object
    public InputField InputField3; // distance
    public float speed = 5;
    public float radius = 100f;
    public float radius2 = 100f;
    public float distance = 500f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3 (0,100,-205);
        InputField.text = "2000";
        InputField1.text = "100";
        InputField2.text = "100";
        InputField3.text = "500";
    }
    public void StartMoveWithDelay()
    {
        StartCoroutine(OrbitE());
        print("nooooo");
    }
    private IEnumerator OrbitE()
    {
        float radius = float.Parse(InputField1.text);
        float speed = float.Parse(InputField.text);
        transform.position = new Vector3 (0,radius,(-radius-105));
        transform.eulerAngles = new Vector3 (0, -45, 0);
        int totalIterations = Mathf.FloorToInt(2 * Mathf.PI * (radius+105)/(speed/35));
        for (int i = 1; i <= totalIterations; i++)
        {
        transform.Rotate(0,(-360.0f/totalIterations),0);
        float angle = (i * 360.0f / totalIterations);
        float x_change = (radius + 105) * Mathf.Cos(angle * Mathf.Deg2Rad);
        float z_change = (radius + 105) * Mathf.Sin(angle * Mathf.Deg2Rad);
        transform.position = new Vector3(x_change, radius, z_change);
        yield return new WaitForSeconds(0.01f);
        }
    }
    public void StartMoveWithDelay2()
    {
        StartCoroutine(Orbit2());
        print("wassup");
    }
    private IEnumerator Orbit2()
    {
        float radius2 = float.Parse(InputField2.text);
        float distance = float.Parse(InputField3.text);
        float speed = float.Parse(InputField.text);
        print(distance);
        transform.position = new Vector3 (0,100,(-radius2-105+distance+500));
        transform.eulerAngles = new Vector3 (0, -45, 0);
        int totalIterations = Mathf.FloorToInt(2 * Mathf.PI * (radius2+105)/(speed/35)); // divide this value by a number to make it go faster
        for (int i = 1; i <= totalIterations; i++)
        {
        transform.Rotate(0,(-360.0f/totalIterations),0);
        float angle = (i * 360.0f / totalIterations);
        float x_change = (radius2 + 105) * Mathf.Cos(angle * Mathf.Deg2Rad);
        float z_change = (radius2 + 105) * Mathf.Sin(angle * Mathf.Deg2Rad);
        transform.position = new Vector3 (x_change,radius2,z_change+distance+500);
        yield return new WaitForSeconds(0.01f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        float speed = float.Parse(InputField.text)/100;
        Thread.Sleep(6);
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward*speed;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward*speed;
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0,-1.75f,0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0,1.75f,0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y+2f,transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y-2f,transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(-1.75f,0,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(1.75f,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,0,1.75f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,0,-1.75f);
        }
        }
    }
