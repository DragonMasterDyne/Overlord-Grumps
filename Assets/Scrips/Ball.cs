using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle paddle1;
    [SerializeField] float velX = 2f;
    [SerializeField] float velY = 15f;
    bool hasStarded = false;


    // State

    Vector2 paddleToBallVector;



    // Start is called before the first frame update
    void Start()
    {
     paddleToBallVector = transform.position - paddle1.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarded)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }
        private void LaunchOnMouseClick()
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(velX,velY);
                hasStarded = true;
            }
        }


        private void LockBallToPaddle()
        {
            Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
            transform.position = paddlePos + paddleToBallVector;
        }

}
