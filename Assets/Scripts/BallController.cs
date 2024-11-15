using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private BallModel _ballModel;
    private Rigidbody2D _rigidBody;


    void Start()
    {
        _ballModel = GetComponent<BallModel>();
        _rigidBody = GetComponent<Rigidbody2D>();


        AngleChange(_ballModel.Direction);

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