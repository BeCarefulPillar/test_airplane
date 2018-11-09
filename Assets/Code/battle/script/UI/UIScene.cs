using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScene : MonoBehaviour {
    /// <summary>
    /// 管理所有需要监听的子物体
    /// </summary>
    Dictionary<string, OnTriggerEvent> items = new Dictionary<string, OnTriggerEvent>();

    /// <summary>
    /// 根据名字在字典当中获取子物体
    /// </summary>
    public OnTriggerEvent GetTrigger(string name) {
        if (items.ContainsKey(name)) {
            return items[name];
        }
        return null;
    }

    public void Init() {
        Find(transform);
    }

    //递归查找子物体
    public void Find(Transform t) {
        OnTriggerEvent item = t.GetComponent<OnTriggerEvent>();
        if (item != null) {
            string name = item.gameObject.name;
            if (!items.ContainsKey(name)) {
                items.Add(name, item);
            }
        }
        for (int i = 0; i < t.childCount; i++) {
            Find(t.GetChild(i));
        }
    }

    // Use this for initialization
    public void Start() {
        Init();
    }
    
    // Update is called once per frame
    void Update() {

    }
}
