using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : MonoBehaviour
{
    private BallController _ballController;

    void Start()
    {
        _ballController = GetComponent<BallController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brik")
        {
            BrikView _brikView = collision.gameObject.GetComponent<BrikView>();
            _brikView.PerformTakeDamage(1);
        }

        if (collision.gameObject.tag == "Jogador")
        {
            //Startar o m�todo de reflexao de jogador
            _ballController.CalcBallAngleReflect(collision);

        }
        else
        {
            //Startar o m�todo de reflex�o convencional
            _ballController.PerfectAngleReflect(collision);
        }


    }
}