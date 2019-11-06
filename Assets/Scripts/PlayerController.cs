using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public Rigidbody myRigidbody;
    public float speed;
    
    public Text scoreText;

    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float movementHorizontal = Input.GetAxis("Horizontal");
        float movementVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementHorizontal, 0f, movementVertical);
        myRigidbody.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Comparo el tag del objeto contra el que he colisionado; para desactivarlo solo en el caso de que sea un Pickup
        if (other.gameObject.CompareTag("Pickup"))
        {
            //Si es Pickup, lo descativo
            other.gameObject.SetActive(false);

            score += other.gameObject.GetComponent<Pickup>().points;
            scoreText.text = "Score = " + score;
        }
    }
}
