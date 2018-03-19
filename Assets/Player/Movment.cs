using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movment : MonoBehaviour {

    public float speedPlayer;
    [Tooltip("have a smooth movement vs avatar jumps from one position to the other")]
    public bool useSmoothRide;
    public Renderer rend;
    public Color GreenColor = new Color();
    //Define Enum
    public enum Props_Enum { Player_BLue, Player_BLack, Player_Yellow, Player_Red, Player_Green };
    
    //This what you need to show in the inspector.
    public Props_Enum Current_props;
    public string Current_Floor;




    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.green;
        Current_Floor = "GreenFloor";
        //rend.material.color = altColor;

    }

    // Update is called once per frame
    void Update()
    {

        Hit_object();
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

        Hit_object();
    }



    public void OnTriggerEnter(Collider other)
    {

        Current_Floor = other.gameObject.tag;
        Hit_object();


    }



    public void Hit_object()
    {
        if (Current_Floor == "RedFloor")
        {
            if (Current_props != Props_Enum.Player_Red)
            {
                Debug.Log("I colide something else22222");
            }
        }
        if (Current_Floor == "BlueFloor")
        {
            if (Current_props != Props_Enum.Player_BLue)
            {
                Debug.Log("I colide something else1111");
            }
        }
        if (Current_Floor == "GreenFloor")
        {
            if (Current_props != Props_Enum.Player_Green)

            {

                Debug.Log("I colide something else33333");

            }
        }
    }

    public void SetColorToBlue()
    {
        rend.material.color = Color.blue;
        Current_props = Props_Enum.Player_BLue;
    }

    public void SetColorToGreen()
    {
        rend.material.color = Color.green;
        Current_props = Props_Enum.Player_Green;
    }

    public void SetColorToBlack()
    {
        rend.material.color = Color.black;
        Current_props = Props_Enum.Player_BLack;
    }

    public void SetColorToYellow()
    {
        rend.material.color = Color.yellow;
        Current_props = Props_Enum.Player_Yellow;
    }

    public void SetColorToRed()
    {
        rend.material.color = Color.red;
        Current_props = Props_Enum.Player_Red;
    }

    



}
