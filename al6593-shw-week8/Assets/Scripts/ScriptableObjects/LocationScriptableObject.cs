using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Location",
    menuName= "ScriptableObjects/Location", order = 0)]

public class LocationScriptableObject : ScriptableObject //based 

{
    public string locationName = "New Place";
    public string description = "Default Description";

    public LocationScriptableObject locationNorth;
    public LocationScriptableObject locationSouth;
    public LocationScriptableObject locationWest;
    public LocationScriptableObject locationEast;
}