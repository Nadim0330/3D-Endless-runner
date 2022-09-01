using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public void onClickPlay()
    {
        SceneManager.LoadScene("gameScene");
    }

    private void onClickMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
