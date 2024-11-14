using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        float unitScaleHalfPlayerPixels = (_playerPixels / 2) /100


        float scaleFactorPutIn1dot8Range = 1.5f





    }
}