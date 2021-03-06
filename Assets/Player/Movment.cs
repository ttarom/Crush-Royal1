﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movment : MonoBehaviour {

    public float speedPlayer;
    [Tooltip("have a smooth movement vs avatar jumps from one position to the other")]
    public bool useSmoothRide;
    public Renderer rend;
    public Color GreenColor = new Color();
    



    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        
        //rend.material.color = altColor;

    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector3.forward * Time.deltaTime * speedPlayer);

        //controlling the player left and right
        if (useSmoothRide)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speedPlayer);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left);
            }
        }

        if (useSmoothRide)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speedPlayer);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right);
            }
        }

        
    }



    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "GreenFloor")
        {
            if (rend.material.color != other.gameObject.GetComponent<Renderer>().material.color)
            {
                Debug.Log("I collide with something ");
            }
        }
        if (other.tag == "BlueFloor")
        {
            if (rend.material.color != other.gameObject.GetComponent<Renderer>().material.color)
            {
                Debug.Log("I collide with something ");
            }
        }
        if (other.tag == "RedFloor")
        {
            if (rend.material.color != other.gameObject.GetComponent<Renderer>().material.color)
            {
                Debug.Log("I collide with something ");
            }
        }
    }





    public void SetColorToBlue()
    {
        rend.material.color = Color.blue;
    }

    public void SetColorToGreen(Collider other)
    {
        rend.material.color = other.gameObject.GetComponent<Renderer>().material.color;
    }

    public void SetColorToBlack()
    {
        rend.material.color = Color.black;
    }

    public void SetColorToYellow()
    {
        rend.material.color = Color.yellow;
    }

    public void SetColorToRed()
    {
        rend.material.color = Color.red;
    }

    public void SetColorToGreenq()
    {
        rend.material.color = Color.green;
    }



}
