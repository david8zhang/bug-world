using UnityEngine;
using System.Collections;

public class LocationList : MonoBehaviour
{
    public Location backyard;
    public Location kitchen;
    public Location street;

    public Location GetLocationByName(string locationName)
    {
        switch (locationName.ToLower())
        {
            case "backyard":
                return backyard;
            case "kitchen":
                return kitchen;
            case "street":
                return street;
            default:
                return backyard;
        }
    }
}
