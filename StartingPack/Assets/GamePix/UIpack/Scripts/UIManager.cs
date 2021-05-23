using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Menu Panels")]
    public GameObject mainPanel;
    public GameObject gamePanel;
    public GameObject failPanel;
    public GameObject winPanel;
   
    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        mainPanel.SetActive(false);
        gamePanel.SetActive(true);
    }

    public void LevelFail()
    {
        gamePanel.SetActive(false);
        failPanel.SetActive(true);
    }

    public void LevelComplete()
    {
        gamePanel.SetActive(false);
        winPanel.SetActive(true);
    }
}
