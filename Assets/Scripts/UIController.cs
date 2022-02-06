using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public static int scorePoints = 0; //Static para ser acessada na classe Enemy

    public Text textScore;
    public GameObject deathScreen;
    public GameObject pauseMenu;
    public string newGameScene, mainMenuScene;

    private bool paused;

    private void Awake() //necessary to active objects in other classes
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score: " + scorePoints.ToString("00000");  
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        if (!UIController.instance.deathScreen.activeSelf)
        {
            if (!paused)
            {
                pauseMenu.SetActive(true);

                paused = true;

                Time.timeScale = 0F;
            }
            else
            {
                pauseMenu.SetActive(false);

                paused = false;

                Time.timeScale = 1F;
            }
        }
    }
}
