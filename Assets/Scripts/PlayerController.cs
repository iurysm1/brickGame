using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel _playerModel;
    private Transform _playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        _playerModel     = GetComponent<PlayerModel>();
        _playerTransform = GetComponent<Transform>();
    }

  

    public void Move(float h)
    {
        if ( (_playerTransform.position.x > -1.4f && h < 0f) ||
             (_playerTransform.position.x < 1.4f && h > 0f)
            ) {
            _playerTransform.Translate(h * _playerModel.Speed, 0f, 0f);

        }
    }

    public PlayerModel getPlayerModel()
    {
        return _playerModel;
    }
    
}
