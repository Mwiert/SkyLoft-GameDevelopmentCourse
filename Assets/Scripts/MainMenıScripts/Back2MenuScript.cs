using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2MenuScript : MonoBehaviour
{
    public void BackToMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1 );
    }
       public void BackToMenuFromInfo(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2 );
    }
}
