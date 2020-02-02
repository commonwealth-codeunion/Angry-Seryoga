using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLeftScript : MonoBehaviour
{
    Text text;
    public static float timeleft = f;

    void Start()
    {
        text = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft < 0)
            timeleft = 0;
        text.text = "Тоби пизда: " + Mathf.Round (timeleft);
    }
}
