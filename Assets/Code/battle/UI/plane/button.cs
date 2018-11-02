using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		OnTriggerEvent item = gameObject.GetComponent<OnTriggerEvent>();
        item.onPointerClick += onClick;
	}

    virtual public void onClick() {
        Debug.LogError("hello world");

    }
    // Update is called once per frame
    public void Update () {
		
	}
}
