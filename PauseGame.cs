using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool paused = false; 
    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetButtonDown("Cancel")) { 
            if (paused == false) { 
                Time.timeScale = 0; 
                paused = true; 
                Cursor.visible = true;
                pauseMenu.SetActive(true); 
               
            } else { 
                pauseMenu.SetActive(false); 
                Cursor.visible = false; 
                paused = false; 
                Time.timeScale = 1;
            } 

    }

        }
        public void ResumeGame() { 
        pauseMenu.SetActive(false); 
        Cursor.visible = false; 
        paused = false; 
        Time.timeScale = 1;
        
    }
        public void MainMenu() { 
            SceneManager.LoadScene(3);
}
}