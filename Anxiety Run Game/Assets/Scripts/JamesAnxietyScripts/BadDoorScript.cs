using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class BadDoorScript : MonoBehaviour
{
    public int anxietyBump = 3;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Bad Choice");
            AnxietyCounter.Instance.IncreaseAnxiety(anxietyBump);
            
        }
    }
}
