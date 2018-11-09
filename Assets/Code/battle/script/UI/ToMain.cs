using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMain : UIScene {

    private OnTriggerEvent Button_ToMain;

    // Use this for initialization
    new void Start () {
	    base.Start();
        Button_ToMain = GetTrigger("Button_ToMain");

        Button_ToMain.onPointerClick += HeroToMain;
	}
	
    private void HeroToMain() {
        Debug.LogError("hello world");

    }
	// Update is called once per frame
	void Update () {
		
	}
}
