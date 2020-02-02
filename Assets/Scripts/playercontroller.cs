using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Player Player;
    
    private void Start()
    {
        Player = Player == null ? GetComponent<Player>() : Player;
        if(Player ==null)
        {
            Debug.LogError("nothing");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Player != null)
        {
            if (Input.GetKey(KeyCode.D))
            {
                Player.MoveRight();
            }
            if (Input.GetKey(KeyCode.A))
            {
                Player.MoveLeft();
            }
            if (Input.GetKey(KeyCode.W))
            {
                Player.MoveUp();
            }
            if (Input.GetKey(KeyCode.S))
            {
                Player.MoveDown();
            }
        }
    }
}
