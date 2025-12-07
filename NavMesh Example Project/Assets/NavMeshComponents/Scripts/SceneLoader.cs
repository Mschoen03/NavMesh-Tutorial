using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadFinished01()
    {
        SceneManager.LoadScene("Finished01");
    }

    public void LoadFinished02()
    {
        SceneManager.LoadScene("Finished02");
    }

    public void LoadFinished03()
    {
        SceneManager.LoadScene("Finished03");
    }

    public void LoadFinished04()
    {
        SceneManager.LoadScene("Finished04");
    }

    public void LoadFinished05()
    {
        SceneManager.LoadScene("Finished05");
    }

    public void LoadFinished06()
    {
        SceneManager.LoadScene("Finished06");
    }
}
