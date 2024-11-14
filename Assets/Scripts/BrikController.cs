using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrikController : MonoBehaviour
{
    BrikModel _brikModel;


    // Start is called before the first frame update
    void Start()
    {
        _brikModel = GetComponent<BrikModel>();
    }
    
    public void TakeDamage(float damage)
    {
        _brikModel.Health = _brikModel.Health - damage;
        if (_brikModel.Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}