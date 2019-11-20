using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chronometer : MonoBehaviour
{
    public Text time;
    public Text downtime;
    float down = 120;
    float chronometer;

    // Start is called before the first frame update
    void Start()
    {
        time.text = "hola";
    }

    // Update is called once per frame
    void Update()
    {

        chronometer += Time.deltaTime;
        time.text = "" + Mathf.Floor(chronometer);

        down -= Time.deltaTime;
        downtime.text = "" + Mathf.Floor(down);
    }
}
