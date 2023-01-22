using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
   public void PlayGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
public void quitGame()
{
    Application.Quit();
}

public void resetData(){
   PlayerPrefs.DeleteAll();
}
   public void InfoScene()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
}
}

