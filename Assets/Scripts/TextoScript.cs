using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextoScript : MonoBehaviour
{

    public TMP_Text texto;

   
    void Start()
    {
        texto = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }


    public void changeText(string text)
    {
        texto.text = text;
    }
}
