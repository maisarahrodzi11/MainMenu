using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    //public void Credit()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}

    public void Quit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Player Has Quit The Game");
    }

    public GameObject Panel;
    
    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }

    public GameObject Credit;

    public void OpenCreditPanel()
    {
        if (Credit != null)
        {
            Credit.SetActive(true);
        }
    }

    public void CloseCreditPanel()
    {
        if (Credit != null)
        {
            Credit.SetActive(false);
        }
    }
}
