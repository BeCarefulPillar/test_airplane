using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plan1 : button {
    private Transform fatherTrans;
    private string prefabPaht = "Prefabs/";
    private Transform myPrefab;
    private GameObject myObj;

    public string prefabName = "test";

    override public void onClick() {
        if (myObj)
            return; 
        fatherTrans = GameObject.Find("Attack").transform;
        myPrefab = ((GameObject)Resources.Load(prefabPaht + prefabName)).transform;
        myObj = Instantiate(myPrefab, fatherTrans).gameObject;
    }
}
