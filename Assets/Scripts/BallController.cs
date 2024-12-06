using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private BallModel _ballModel;
    private Rigidbody2D _rigidBody;
    private GameObject canvas;
    private PlayerController _player;
    private int _vida = 1;

    void Start()
    {
        _ballModel = GetComponent<BallModel>();
        _rigidBody = GetComponent<Rigidbody2D>();
        canvas = GameObject.Find("Canvas");
        canvas.SetActive(false);


        AngleChange(_ballModel.Direction);

    }

    void Update()
    {
        if (_ballModel.transform.position.y < -5.316)
        {
            _vida = _vida - 1 ;
            Vector3 newPosition = _ballModel.transform.position;
            newPosition.y = -1.44f;
            _ballModel.transform.position = newPosition;
            if (_vida == 0)
            {
                Time.timeScale = 0f;
                canvas.SetActive(true);
            }
            //SceneManager.LoadScene("fase_2");
        }
    }

    public void AngleChange(Vector2 direction)
    {
        _ballModel.Direction = direction;
        _rigidBody.velocity  = direction * _ballModel.Speed;

    }

    public void PerfectAngleReflect(Collision2D collision)
    {
        AngleChange(Vector2.Reflect(_ballModel.Direction, 
                    collision.contacts[0].normal));
    }

    public void CalcBallAngleReflect(Collision2D collision)
    {
        //Tamanho do player 120px
        float _playerPixels = 120f;


        //Pegando o tamanho do player e colocando na escala do unity
        float unitScaleHalfPlayerPixels = _playerPixels / 2f / 100f;


        float scaleFactorPutIn1dot8Range = 1.5f;


        float angleDegUnitScale = ((collision.transform.position.x - transform.position.x) + unitScaleHalfPlayerPixels) * scaleFactorPutIn1dot8Range;


        float angleDeg = angleDegUnitScale * 100f;

        if(angleDeg < 7f) {
            angleDeg = 10f;
        }else if(angleDeg > 173f) {
            angleDeg = 170f;
        };

        //Converter o angule de graus para Radianos
        float angleRad = angleDeg * Mathf.PI / 180f;
        UnityEngine.Debug.Log(angleRad);


        //X e Y serçao extraidos pelo Seno e Cosseno
        Vector2 _vetorDeRetorno = new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad)); 

        //Carregando o novo angulo de posições
        AngleChange(_vetorDeRetorno);

    }
}