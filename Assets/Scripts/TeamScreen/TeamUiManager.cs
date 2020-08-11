using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TeamUiManager : MonoBehaviour
{

    public void GotoExploreScene()
    {
        SceneManager.LoadScene("Explore");
    }
}
