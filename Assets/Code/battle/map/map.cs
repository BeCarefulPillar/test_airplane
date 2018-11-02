using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Sunkang {
    class Grid {
        Vector2 postion;
        bool isHas;
        Grid() {
            postion = new Vector2((float)0.75, (float)0.75);
            isHas = false;
        }
    }

    public class map {
        private Grid[,] grids = new Grid[6, 10];


        // Use this for initialization
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }
    }
}
