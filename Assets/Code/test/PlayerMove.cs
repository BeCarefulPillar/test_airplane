using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public Vector2 speed = new Vector2(10.0f, 10.0f);

    private Rigidbody2D rig;
    private Vector2 movement = new Vector2(0, 0);  //移动量

    void Move() {
        if (Input.GetKey("left"))
            movement = new Vector2(-speed.x, 0);
        else if (Input.GetKey("right"))
            movement = new Vector2(speed.x, 0);
        else if (Input.GetKey("up"))
            movement = new Vector2(0, speed.y);
        else if (Input.GetKey("down"))
            movement = new Vector2(0, -speed.y);
        else
            movement = new Vector2(0, 0);
        //Debug.Log(Event.current.keyCode);

    }

    // Use this for initialization
    void Start () {
        if (rig == null)
            rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rig.velocity = movement;
    }

	// Update is called once per frame
	void Update () {
        Move();
    }
}
