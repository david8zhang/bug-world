using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BugDisplayCard : MonoBehaviour
{
    public TextMeshProUGUI bugNameText;
    public TextMeshProUGUI levelText;
    public Image image;
    public BugSprites bugSprites;

    public void Create(Bug bug)
    {
        bugNameText.text = bug.bugName;
        levelText.text = "Lv. " + bug.level.ToString();
        image.sprite = bugSprites.GetSprite(bug.type);
    }
}
