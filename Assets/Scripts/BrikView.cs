using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrikView : MonoBehaviour
{
    BrikController _brikController;


    // Start is called before the first frame update
    void Start()
    {
        _brikController = GetComponent<BrikController>();
    }

    public void PerformTakeDamage(float damage)
    {
        _brikController.TakeDamage(damage);
    }
}