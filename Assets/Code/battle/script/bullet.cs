using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        Vector3 pos = gameObject.transform.position;
        gameObject.transform.position = pos + new Vector3(speed * Time.deltaTime, 0, 0);
        if (pos.x > 20.0f) {
            Destroy(gameObject);
        }
    }
}
