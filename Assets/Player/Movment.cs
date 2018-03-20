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
    public float HP;
    public float StartTime;
    public float TimeStamp;
    public Animator PlayerAnimator;



    // Use this for initialization
    void Start ()
    {
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

       // if (GapTime == true)
        {
           // if (TimeStamp < (StartTime - 1))
            {
                
                //this.gameObject.transform.position = Position;
               // GetComponent<Rigidbody>().useGravity = false;
              //  GapTime = false;
                

            }
        }
       
        StartTime = Time.time;

    }



    public void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bluff")
        {
            Debug.Log("Bluff");
            HP = HP + 1;

        }

        if (other.tag == "Abyss")
        {
            Debug.Log("Abyss");
            HP = HP + 1;
            TimeStamp = StartTime;
            PlayerAnimator.SetTrigger("Fall");





        }


        if (other.tag == "GreenFloor")
        {
           // if (rend.material.color != "RGBA(0.000, 1.000, 0.000, 1.000)")
           // {
           //     Debug.Log("I collide with something ");
          //  }
        }
    }


    public void SetColorToBlue()
    {
        rend.material.color = Color.blue;
    }

    public void SetColorToGreen()
    {
        rend.material.color = Color.green;
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




}
