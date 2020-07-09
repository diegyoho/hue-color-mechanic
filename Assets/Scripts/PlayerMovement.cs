using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float speed;

    void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = (
            Vector2.right * speed * Input.GetAxisRaw("Horizontal")
        );
    }
}
