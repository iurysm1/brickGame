using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrikController : MonoBehaviour
{
    BrikModel _brikModel;

    [SerializeField] public AudioClip rato;

    public AudioSource audioSource;



    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayOneShot(rato);


        _brikModel = GetComponent<BrikModel>();
    }
    
    public void TakeDamage(float damage)
    {
        audioSource.PlayOneShot(rato);


        _brikModel.Health = _brikModel.Health - damage;
        if (_brikModel.Health <= 0)
        {
            audioSource.Play();
            Destroy(gameObject);
        }
    }
}