using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public int points = 1;
    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(15, 30, 45) * Time.deltaTime;
        transform.Rotate(rotation);
    }
}
