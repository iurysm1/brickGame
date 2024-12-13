using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public GameObject startGame;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame()
    {
        startGame.SetActive(false);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
    }

}
