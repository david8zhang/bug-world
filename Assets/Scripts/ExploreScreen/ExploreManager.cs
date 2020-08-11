using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ExploreManager : MonoBehaviour
{
    public TextMeshProUGUI locationLabel;
    public Image locationImage;
    public LocationList locationList;

    public void Start()
    {
        // Initialize the UI
        string currentLocationName = PlayerPrefs.GetString("player_loc", "backyard");
        Location currentLocation = locationList.GetLocationByName(currentLocationName);
        locationImage.sprite = currentLocation.locationImage;
        locationLabel.text = "You are currently in: " + currentLocation.name;
    }

    public void GotoFightScene()
    {
        SceneManager.LoadScene("Fight");
    }

    public void GotoMoveScene()
    {
        SceneManager.LoadScene("Move");
    }

    public void GotoTeamScene()
    {
        SceneManager.LoadScene("Team");
    }
}
