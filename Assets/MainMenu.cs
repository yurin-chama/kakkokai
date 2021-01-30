using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Quit game
    public void QuitGame()
    {
        Application.Quit();
    }
    
    //Play
    public void PlayGame()
    {
        StartCoroutine(LoadPlay());
    }
    
    IEnumerator LoadPlay(){
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Arena");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
