using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f;
    public Text ScoreText;
    private int count = 0;
    public Text WinText;

    

void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
      
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {   
            other.gameObject.SetActive(false);
            count += 1;
            ScoreText.text = "Score:" + count;
        }
        if (count >= 28)
        {
            WinText.gameObject.SetActive(true);
        }

    }
    
}
