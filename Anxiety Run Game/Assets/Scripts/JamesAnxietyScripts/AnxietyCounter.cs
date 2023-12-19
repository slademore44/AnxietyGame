using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnxietyCounter : MonoBehaviour
{
    public static AnxietyCounter Instance;

    public TMP_Text anxietyText;

    public int currentAnxiety = 0;

    void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        anxietyText.text = "" + currentAnxiety.ToString();
    }


    public void IncreaseAnxiety(int v)
    {
        currentAnxiety += v;
        anxietyText.text = "" + currentAnxiety.ToString();
    }
}
