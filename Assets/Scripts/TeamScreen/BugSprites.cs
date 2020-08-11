using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugSprites : MonoBehaviour
{
    [SerializeField]
    public Sprite ant;

    public Sprite GetSprite(string type)
    {
        switch (type)
        {
            case "ant":
                return ant;
            default:
                return null;
        }
    }
}
