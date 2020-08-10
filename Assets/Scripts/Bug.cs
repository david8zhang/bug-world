using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bug", menuName = "Bug")]
public class Bug : ScriptableObject
{
    public string bugName;
    public int attack;
    public int defense;
    public int health;
    public int speed;
    public int experience;
    public int level;
    public Sprite image;
}
