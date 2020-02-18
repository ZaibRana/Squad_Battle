using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void Clickplay()
    {
        SoundPlayer._instance.PlaySound("button");
        Invoke("LoadScene", 0.2f);
    }

    public void Clickprofile()
    {
        SoundPlayer._instance.PlaySound("button");
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(1);
    }

}
