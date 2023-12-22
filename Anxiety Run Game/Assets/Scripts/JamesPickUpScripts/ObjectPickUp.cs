using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickUp : MonoBehaviour
{
    public GameObject crossHair1, crossHair2;
    public Transform objectTransform, cameraTransform;
    public bool interactable, pickedUp;
    public Rigidbody objRigidbody;
    public float throwAmount;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag ("MainCamera"))
            {
            crossHair1.SetActive(false);
            crossHair2.SetActive(true);
            interactable = true;
            }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag ("MainCamera"))
        {
            crossHair1.SetActive(true);
            crossHair2.SetActive(false);
            interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(interactable == true)
        {
            if(Input.GetMouseButtonDown(0)) 
            {
                objectTransform.parent = cameraTransform;
                objRigidbody.useGravity = false;
                objRigidbody.velocity = cameraTransform.forward * 0;
                pickedUp = true;
            }

            if(Input.GetMouseButtonUp(0))
            {
                objectTransform.parent = null;
                objRigidbody.useGravity = true;
                pickedUp = false;
            }

            if (pickedUp == true)
            {
                if (Input.GetMouseButtonDown(1))
                {
                    objectTransform.parent = null;
                    objRigidbody.useGravity = true;    
                    objRigidbody.velocity = cameraTransform.forward * throwAmount * Time.deltaTime;
                    pickedUp = false;
                }


             }

        }
    }
}
