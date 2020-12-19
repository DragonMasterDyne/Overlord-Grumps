using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField] float unityUnits = 16f;
    [SerializeField] float xMax = 15f;
    [SerializeField] float xMin = 1f;


    void Start()
    {
        
    }

    void Update()
    {
        float xPos = Input.mousePosition.x/Screen.width * unityUnits;
        Vector2 paddlePos = new Vector2 (transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(xPos,xMin, xMax);
        transform.position = paddlePos;
    }
}
