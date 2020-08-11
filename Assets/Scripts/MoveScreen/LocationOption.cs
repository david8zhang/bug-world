using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LocationOption : MonoBehaviour
{
    public TextMeshProUGUI locationNameLabel;
    public Image locationImage;
    public Button moveButton;

    public void Create(Location loc)
    {
        locationNameLabel.text = loc.locationName;
        locationImage.sprite = loc.locationImage;
        moveButton.onClick.AddListener(() => MoveToLocation(loc.locationName));
    }

    public void MoveToLocation(string locationName)
    {
        PlayerPrefs.SetString("player_loc", locationName);
        SceneManager.LoadScene("Explore");
    }
}
