using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movment : MonoBehaviour
{

    public float speedPlayer;
    [Tooltip("have a smooth movement vs avatar jumps from one position to the other")]
    public bool useSmoothRide;
    public Renderer rend;
    public Color GreenColor = new Color();
    public float CurrentHealth;
    public float MaxHealth;
    //Define Enum
    public enum Props_Enum { Player_BLue, Player_BLack, Player_Yellow, Player_Red, Player_Green };

    //This what you need to show in the inspector.
    public Props_Enum Current_props;
    private string Current_Floor;
    public Slider HealthBar;




    // Use this for initialization
    void Start()
    {
        CurrentHealth = MaxHealth;
        rend = GetComponent<Renderer>();
        rend.material.color = Color.green;
        Current_Floor = "GreenFloor";
        HealthBar.value = CalaulateDamage();
        Current_props = Props_Enum.Player_Green;
        //rend.material.color = altColor;

    }

    // Update is called once per frame
    void Update()
    {

        Deal_Damage(1);
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

        Current_Floor = other.gameObject.tag;
        Deal_Damage(6);
        Debug.Log("bla");

    }



    public void Deal_Damage(float DamageValue)
    {
        if (Current_Floor == "RedFloor")
        {
            if (Current_props != Props_Enum.Player_Red)
            {
                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();
            }
        }
        if (Current_Floor == "BlueFloor")
        {
            if (Current_props != Props_Enum.Player_BLue)
            {
                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();
            }
        }
        if (Current_Floor == "GreenFloor")
        {
            if (Current_props != Props_Enum.Player_Green)

            {

                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();

            }
        }
        if (Current_Floor == "PinkFloor")
        {
            if (Current_props != Props_Enum.Player_Yellow)

            {

                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();

            }
        }
        if (Current_Floor == "OrangeFloor")
        {
            if (Current_props != Props_Enum.Player_BLack)

            {

                CurrentHealth -= DamageValue;
                HealthBar.value = CalaulateDamage();

            }
        }
    }

    float CalaulateDamage()
    {
        return CurrentHealth / MaxHealth;
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
        rend.material.color = new Color(0.859f, 0.404f, 0.827f);
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
