using System;
using System.Collections.Generic;
using UnityEngine;

public class UIPanel<T> : MonoBehaviour where T : Component {
    private static T target;
    public static T Instance {
        get {
            target = GameObject.FindObjectOfType(typeof(T)) as T;
            if (target == null) {
                GameObject go = new GameObject();
                target = go.AddComponent<T>();
            }
            return target;
        }

    }
}
