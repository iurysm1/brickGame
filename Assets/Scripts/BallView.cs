using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallView : MonoBehaviour
{
    private BallController _ballController;
    private int pontos;
    public TextoScript textoPontos;

    void Start()
    {
        _ballController = GetComponent<BallController>();
        textoPontos = GameObject.Find("Pontos").GetComponent<TextoScript>();

        pontos = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brik")
        {
            UnityEngine.Debug.Log(GameObject.FindGameObjectsWithTag("Brik").Length);

            if (GameObject.FindGameObjectsWithTag("Brik").Length == 1)
            {
                UnityEngine.Debug.Log("NOVAFASE");

                SceneManager.LoadScene("fase_2");

            }
            else
            {

                BrikView _brikView = collision.gameObject.GetComponent<BrikView>();
                _brikView.PerformTakeDamage(1);
                pontos += 10;
                textoPontos.changeText(pontos.ToString());
            }

        }

        if (collision.gameObject.tag == "Jogador")
        {
            //Startar o método de reflexao de jogador
            _ballController.CalcBallAngleReflect(collision);
            pontos -= 5;
            textoPontos.changeText(pontos.ToString());

        }
        else
        {
            //Startar o método de reflexão convencional
            _ballController.PerfectAngleReflect(collision);
        }


    }
}