using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public LocationScriptableObject currentLocation;

    public Text locationNameText;
    public Text locationDescription;

    public GameObject buttonNorth;
    public GameObject buttonSouth;
    public GameObject buttonWest;
    public GameObject buttonEast;

    // Start is called before the first frame update
    void Start()
    {
        UpdateLocation();
    }

    public void MoveDirection(int dir)
    {
        /*if (dir == 0)
        {
            currentLocation = currentLocation.locationNorth;
        }*/

        switch (dir) //the switch statement will allow u to use the dir var against a # of constants
        {
            case 0:
                currentLocation = currentLocation.locationNorth; //north switch
                break;
            case 1:
                currentLocation = currentLocation.locationSouth; //south switch
                break;
            case 2:
                currentLocation = currentLocation.locationWest; //west switch
                break;
            case 3:
                currentLocation = currentLocation.locationEast; //east switch
                break;
            default: //not necessarily needed, but for good measure 
                break;
        }

            UpdateLocation();   
    }
    
    void UpdateLocation()
    {
        //Debug.Log(currentLocation);
        locationNameText.text = currentLocation.locationName;
        locationDescription.text = currentLocation.description;

        if (currentLocation.locationNorth == null) //if you don't have location North
        {
            buttonNorth.SetActive(false); //the button will be hidden or false 
        }
        else //if the location DOES NOT equal to null
        {
            currentLocation.locationNorth.locationSouth = currentLocation;
            buttonNorth.SetActive(true); //the button will be true 
        }

        if (currentLocation.locationSouth == null) 
        {
            buttonSouth.SetActive(false); 
        }
        else
        {
            currentLocation.locationSouth.locationNorth = currentLocation;
            buttonSouth.SetActive(true);
        }

        if (currentLocation.locationWest == null)
        {
            buttonWest.SetActive(false);
        }
        else
        {
            currentLocation.locationWest.locationEast = currentLocation;
            buttonWest.SetActive(true);
        }

        if (currentLocation.locationEast == null)
        {
            buttonEast.SetActive(false);
        }
        else
        {
            currentLocation.locationEast.locationWest = currentLocation; 
            buttonEast.SetActive(true);
        }
    }
}