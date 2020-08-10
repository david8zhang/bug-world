using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BugDisplay : MonoBehaviour
{

    public Bug bug;
    public TextMeshProUGUI bugNameText;
    public TextMeshProUGUI levelText;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        bugNameText.text = bug.bugName;
        levelText.text = "Lv. 1";
        image.sprite = bug.image;
    }
}
