using System;
using System.Collections.Generic;
using UnityEngine;

public class UISceneName {
    public const string Panel_Game = "Panel_Game";
}

public class UIManager : UIPanel<UIManager> {
    //保存所有的panel
    Dictionary<string, UIScene> scenes = new Dictionary<string, UIScene>();

    public void Init() {
        UIScene[] items = GameObject.FindObjectsOfType<UIScene>();
        for (int i = 0; i < items.Length; i++) {
            UIScene go = items[i];
            if (!scenes.ContainsKey(go.name)) {
                scenes.Add(go.name, go);
                go.gameObject.SetActive(false);
            }

        }
    }

    public UIScene GetUIScene(string name) {
        if (scenes.ContainsKey(name)) {
            return scenes[name];
        }

        return null;
    }

    public void IsActive(string name, bool isActive) {
        GameObject go = scenes[name].gameObject;
        if (go == null) {
            Debug.LogError("find error");
            return;
        }
        go.gameObject.SetActive(isActive);
    }

    public void ShowUI() {
        IsActive(UISceneName.Panel_Game, true);
    }
    
}


