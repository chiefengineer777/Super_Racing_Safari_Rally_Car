using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void selectLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void playLevelOne()
    {
        SceneManager.LoadScene(2);
    }

    public void playLevelTwo()
    {
        SceneManager.LoadScene(3);
    }

    public void playLevelThree()
    {
        SceneManager.LoadScene(4);
    }

    public void playLevelFour()
    {
        SceneManager.LoadScene(5);
    }

    public void playLevelFive()
    {
        SceneManager.LoadScene(6);
    }

    public void playLevelSix()
    {
        SceneManager.LoadScene(7);
    }

    public void about()
    {
        SceneManager.LoadScene(8);
    }

    public void quit()
    {
        //Application.Quit();
        SceneManager.LoadScene(9);
    }
}
