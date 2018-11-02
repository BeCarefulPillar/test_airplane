using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour {
    private Vector3 mousePosition, targetPosition;
    private Transform fatherTrans;

    private string prefabPaht = "Prefabs/";
    private Transform myPrefab;

    public string prefabName = "SunFlower";
    // Use this for initialization
    void Start() {
        fatherTrans = GameObject.Find("Attack").transform;
        myPrefab = ((GameObject)Resources.Load(prefabPaht + prefabName)).transform;
    }

    // Update is called once per frame
    void Update() {
        mousePosition = Input.mousePosition;
        Vector3 pos = Camera.main.WorldToViewportPoint(fatherTrans.position);
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, pos.z));
        transform.position = targetPosition;

        myPrefab.position = targetPosition;

        if (Input.GetMouseButtonUp(0)) {
            Instantiate(myPrefab, myPrefab.position, myPrefab.rotation, fatherTrans);
            Destroy(gameObject);
        }
    }


}
