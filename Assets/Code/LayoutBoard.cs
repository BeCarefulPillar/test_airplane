using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutBoard : MonoBehaviour {

    private Transform _transfrom;

    public Vector2 size = new Vector2(10, 20);
    public int widNum = 11;
    public int lenNum = 6;

    // Use this for initialization
    void Start() {
        
    }

    private void OnDrawGizmos() {
        for (int i = 0; i < lenNum; i++) {
            Gizmos.DrawLine(new Vector3(0, i * size.y, 0), new Vector3((widNum - 1) * size.x, i * size.y, 0));
        }
        for (int i = 0; i < widNum; i++) {
            Gizmos.DrawLine(new Vector3(i * size.x, 0, 0), new Vector3(i * size.x, (lenNum - 1) * size.y, 0));
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
