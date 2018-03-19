using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movment : MonoBehaviour {

    public float speedPlayer;
    [Tooltip("have a smooth movement vs avatar jumps from one position to the other")]
    public bool useSmoothRide;
    public Renderer rend;
    public Color altColor = Color.green;
    //Define Enum
    public enum PropsEnum { Player_Blue, Player_Green, Player_Red, Player_Black, Player_Yellow };

    //This is what you need to show in the inspector.
    public PropsEnum Current_props;

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
            if (Current_props != PropsEnum.Player_Green)
            {
                Debug.Log("I collide with something ");
            }
        }
    }


    public void SetColorToBlue()
    {
        rend.material.color = Color.blue;
        Current_props = PropsEnum.Player_Blue;
    }

    public void SetColorToGreen()
    {
        rend.material.color = Color.green;
        Current_props = PropsEnum.Player_Green;
    }

    public void SetColorToBlack()
    {
        rend.material.color = Color.black;
        Current_props = PropsEnum.Player_Black;
    }

    public void SetColorToYellow()
    {
        rend.material.color = Color.yellow;
        Current_props = PropsEnum.Player_Yellow;
    }

    public void SetColorToRed()
    {
        rend.material.color = Color.red;
        Current_props = PropsEnum.Player_Red;
    }




}
