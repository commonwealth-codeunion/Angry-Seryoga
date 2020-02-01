using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScript : MonoBehaviour
{

    private bool pickUpAllowed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    void OnTriggerEnter2D(Colider2D collision)
    {
        if (collision.gameObject.name.Equal("Drovosek"))
        {
            pickUpAllowed = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
    }

}
