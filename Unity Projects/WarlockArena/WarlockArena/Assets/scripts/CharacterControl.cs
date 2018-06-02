using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {
    private float speed = 10f; // movement speed
    private Rigidbody2D rb;
    public new GameObject camera;
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime, moveXt = 0;
        float moveY = Input.GetAxis("Vertical") * speed * Time.deltaTime, moveYt = 0;

        if (Mathf.Abs(rb.position.x - camera.transform.position.x) < 9 || (Mathf.Abs((rb.position.x + moveX) - camera.transform.position.x) < Mathf.Abs(rb.position.x - camera.transform.position.x)))
            moveXt = moveX;
        if (Mathf.Abs(rb.position.y - camera.transform.position.y) < 5 || (Mathf.Abs((rb.position.y + moveY) - camera.transform.position.y) < Mathf.Abs(rb.position.y - camera.transform.position.y)))
            moveYt = moveY;
        rb.MovePosition(rb.position + Vector2.right * moveXt + Vector2.up * moveYt);
    }
}
