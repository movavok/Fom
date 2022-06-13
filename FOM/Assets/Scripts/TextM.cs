using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextM : MonoBehaviour
{
    private string text;
    
    private void Start()
    {
        text = GetComponent<Text>().text;
        GetComponent<Text>().text = "";
        StartCoroutine(TextCoroutine());
        
    }

    IEnumerator TextCoroutine()
    {
        foreach (char abc in text)
        {
            GetComponent<Text>().text += abc;
            yield return new WaitForSeconds(0.1f);
            
        }
    }

  
}