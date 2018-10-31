using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public Vector2 speed = new Vector2(2, 2);

    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;
    private Rigidbody2D rig;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        movement = new Vector2(
            speed.x * direction.x,
            speed.y * direction.y
            );
    }

    private void FixedUpdate() {
        if(rig == null)
            rig = GetComponent<Rigidbody2D>();

        rig.velocity = movement;
    }
}
