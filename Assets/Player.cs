using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 15f;
    public float gameWidth = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Use Fixed Update to make changes on a fixed interval
    private void FixedUpdate()
    {
        //Get horizontal input and adjust the -1 to 1 value based on the delta
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -gameWidth, gameWidth);

        rb.MovePosition(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().EndGame();
    }
}
