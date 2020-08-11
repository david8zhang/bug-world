using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveManager : MonoBehaviour
{
    public LocationOption[] locationOptions;
    public LocationList locationList;

    public void Start()
    {
        InitializeOptions();
    }

    private void InitializeOptions()
    {
        string locationName = PlayerPrefs.GetString("player_loc", "backyard");
        Location currentLocation = locationList.GetLocationByName(locationName);
        Location[] reachableLocations = currentLocation.reachableLocations;
        for (int i = 0; i < locationOptions.Length; i++)
        {
            if (i < reachableLocations.Length)
            {
                locationOptions[i].Create(reachableLocations[i]);
            } else
            {
                locationOptions[i].gameObject.SetActive(false);
            }
        }
    }

    public void MoveToLocation(string locationName)
    {
        PlayerPrefs.SetString("player_loc", locationName);
        SceneManager.LoadScene("Explore");
    }
}
