using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    int speed = 3;
    void Update()
    {
        float playerMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerMove = speed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerMove = -speed * Time.deltaTime;
        }

        this.transform.Translate(new Vector3(playerMove, 0, 0));



    }
}