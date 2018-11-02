using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutBoard : MonoBehaviour {

    public GameObject gameObject;

    private Vector2 size = new Vector2((float)0.75, (float)0.75);
    public int widNum = 10;
    public int lenNum = 6;

    private void DrawRect(Vector2 pos) {
        Debug.DrawLine(new Vector3(pos.x, pos.y, gameObject.transform.position.z), new Vector3(pos.x, pos.y + size.y, gameObject.transform.position.z), new Color(1, 0, 0));
        Debug.DrawLine(new Vector3(pos.x, pos.y + size.y, gameObject.transform.position.z), new Vector3(pos.x + size.x, pos.y + size.y, gameObject.transform.position.z), new Color(1, 0, 0));
        Debug.DrawLine(new Vector3(pos.x + size.x, pos.y + size.y, gameObject.transform.position.z), new Vector3(pos.x + size.x, pos.y, gameObject.transform.position.z), new Color(1, 0, 0));
        Debug.DrawLine(new Vector3(pos.x + size.x, pos.y, gameObject.transform.position.z), new Vector3(pos.x, pos.y, gameObject.transform.position.z), new Color(1, 0, 0));
    }

    // Use this for initialization
    void Start() {
        GameObject fightAreaObject = GameObject.Find("FightArea");
        Vector3 fightAreaSize = fightAreaObject.GetComponent<SpriteRenderer>().sprite.bounds.size;

        if (fightAreaSize.x > 0 && fightAreaSize.y > 0) {
            Vector3 scale = new Vector3(size.x * widNum / fightAreaSize.x, size.y * lenNum / fightAreaSize.y, 1);
            fightAreaObject.transform.localScale = scale;
        }
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < widNum; i++) {
            for (int j = 0; j < lenNum; j++) {
                DrawRect(new Vector2(i * size.x + gameObject.transform.position.x, j * size.y + gameObject.transform.position.y));
            }
        }
    }
}
