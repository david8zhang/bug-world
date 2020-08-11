using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[CreateAssetMenu (fileName = "New Location", menuName = "Location")]
public class Location : ScriptableObject
{
    public string locationName;
    public Sprite locationImage;
    public Location[] reachableLocations;
}
