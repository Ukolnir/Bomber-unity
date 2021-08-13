using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameIsOver = false;
    public GameObject pauseMenuUI;
    
    void Update(){
        if (GameIsOver) {
            pauseMenuUI.transform.Find("RestartButton").gameObject.SetActive(true);
            pauseMenuUI.transform.Find("ResumeButton").gameObject.SetActive(false);
            GameOver();
        }
        
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (GameIsPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Restart(){
        Time.timeScale = 1f;
        GameIsOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void GameOver() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMenu() {
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameIsOver = false;
        SceneManager.LoadScene("Menu");
    }

    public void Quit() {
        Application.Quit();
    }
}
