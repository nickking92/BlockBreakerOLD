using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
   public  float autoLoadnextLevel;
   

    void Start()
    {
        if (autoLoadnextLevel <= 0)
        {
         
        }
        else
        {
            Invoke("AutoLoadNextLevel", autoLoadnextLevel);
        }
    }


   public  IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(0.1f); // wait 1 seconds
        SceneManager.LoadScene(levelName);

    }

    public void LoadScene(string selection)
    {
        StartCoroutine(LoadAfterDelay(selection));
        
        // AdManager.Instance.ShowBanner();
    }


    void AutoLoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }

}

