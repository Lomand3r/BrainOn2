using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;


    void Update()
    {
                // Si on appuie sur ESC
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Si le jeu est d�j� en pause
            if (GameIsPaused)
            {
                Resume();
            }
            // Si le jeu n'est pas en pause
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        // D�sactive le menu Pause
        pauseMenuUI.SetActive(false);
        // Reprend le temps r�el du jeu
        Time.timeScale = 1f;

        GameIsPaused = false;
    }

    void Pause()
    {
            // Active le menu Pause
        pauseMenuUI.SetActive(true);
            // Arr�te le temps du jeu en fond
        Time.timeScale = 0f;

        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        // Reprend le temps r�el du jeu
        Time.timeScale = 1f;
        // M�ne vers une autre sc�ne appel� "MainMenu" (/!\check les build settings qu'il s'agisse du bon nom)
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
