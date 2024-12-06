using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JogarNovamente : MonoBehaviour
{

    public void TrocarCena()
    {

        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;

    }
}
