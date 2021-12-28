using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private int nextScene;
    private int currScene;
    private string stage;

    private void Start()
    {
        currScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("CurrScene", currScene);
        PlayerPrefs.SetInt("NextScene", currScene);
        nextScene = currScene + 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            PlayerPrefs.SetInt("available", 1);
            PlayerPrefs.SetInt("NextScene", nextScene);
            SceneManager.LoadScene(3);
        }
    }
    
  
}       
