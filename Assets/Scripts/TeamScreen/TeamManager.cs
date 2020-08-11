using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamManager : MonoBehaviour
{
    public BugDisplayCard[] starterSlots;
    public TextAsset playerTeamData;
    public Team bugTeam;

    private void Awake()
    {
        bugTeam = JsonUtility.FromJson<Team>(playerTeamData.text);
    }

    private void Start()
    {
        ShowBugTeam();
    }

    void ShowBugTeam()
    {
        Bug[] bugs = bugTeam.team;
        for (int i = 0; i < starterSlots.Length; i++)
        {
            BugDisplayCard card = starterSlots[i];
            if (i < bugs.Length)
            {
                card.Create(bugs[i]);
            } else
            {
                card.gameObject.SetActive(false);
            }
        }
    }
}
