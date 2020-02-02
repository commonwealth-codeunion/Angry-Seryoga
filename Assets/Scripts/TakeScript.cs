using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeScript : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;

    private bool pickUpAllowed;
    private bool isArmed;

    // Start is called before the first frame update
    void Start()
    {
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()   
    {
        if (!pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.parent = null;
            pickUpAllowed = true;
        }
        else if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Drovosek"))
        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Drovosek"))
        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }

    }

    private void PickUp()
    {
        if (!isArmed)
        {
        gameObject.transform.parent = GameObject.FindWithTag("Player").transform;
        gameObject.transform.localPosition = new Vector3(1.9f,-0.7f, -2);
        pickUpAllowed = false;
        }
    }

}
