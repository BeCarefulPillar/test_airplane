using System;
using System.Collections.Generic;
using UnityEngine;

namespace SunKang {
    public class Main : MonoBehaviour {
        private void Start() {
            UIManager.Instance.Init();
            UIManager.Instance.ShowUI();
        }
    }
}
