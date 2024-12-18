using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{

    

    [SerializeField] private float _speed;
    [SerializeField] private int _life;

    public float Speed { get => _speed; set => _speed = value; }
    public int Life { get => _life; set => _life = value; }


    public Collider2D getCollider()
    {
        return gameObject.GetComponent<Collider2D>();
    }
}
