using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public int Green_floor = 1;
    public enum Props_Enum { Player_BLue, Player_BLack, Player_Yellow, Player_Red, Player_Green };
    public Props_Enum Current_floor = Props_Enum.Player_Green;
    private Props_Enum Current_props;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
      
      if (Current_floor != Current_props)
        {
            Debug.Log("I Clide");
        }

    }
    public void SetColorToBlue()
    {
        
        Current_props = Props_Enum.Player_BLue;
    }

    public void SetColorToGreen()
    {
        
        Current_props = Props_Enum.Player_Green;
    }

    public void SetColorToBlack()
    {
        
        Current_props = Props_Enum.Player_BLack;
    }

    public void SetColorToYellow()
    {
        
        Current_props = Props_Enum.Player_Yellow;
    }

    public void SetColorToRed()
    {
        
        Current_props = Props_Enum.Player_Red;
    }
}
