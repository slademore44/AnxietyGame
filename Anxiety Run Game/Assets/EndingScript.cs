using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScript : MonoBehaviour
{
    public AnxietyCounter counter;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Cube Entered");

            if(counter.currentAnxiety > 9) 
            {
                Debug.Log("Bad Ending");
            }
            else
            {
                Debug.Log("Good Ending");
            }
            
        }
    }

}
        
