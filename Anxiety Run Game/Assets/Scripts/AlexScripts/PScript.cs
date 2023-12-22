using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PScript : MonoBehaviour
{
    public float speed = 1.5f;
    public float limit = 75f;
    public bool randomStart = false;
    public float random = 0;

    private void Awake()
    {
        if (randomStart)
            random = Random.Range(0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float angle = limit * Mathf.Sin(Time.time + random * speed);
        transform.localRotation = Quaternion.Euler(angle, 0, 0);
    }
}
