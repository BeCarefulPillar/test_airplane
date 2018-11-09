using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SunKang {
    public class Grid {
        public Vector2 size;
        public bool isHas;

        public Grid() {
            size = new Vector2((float)0.75, (float)0.75);
            isHas = false;
        }
        public Grid(Vector2 size) {
            this.size = size;
            isHas = false;
        }
    }

    public class map {
        public Grid[,] grids;
        public int id { set; get; }
        public map() {
            grids = new Grid[6, 10];
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 10; j++) {
                    grids[i, j] = new Grid();
                }
            }
        }
        public map(Vector2 size) {
            grids = new Grid[6, 10];
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 10; j++) {
                    grids[i, j] = new Grid(size);
                }
            }
        }
        public map(int x, int y, Vector2 size) {
            grids = new Grid[x, y];
            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    grids[i, j] = new Grid(size);
                    Debug.Log(size.x + "   " + size.y);
                }
            }
        }

        public bool GetMapStatus(int x, int y) {
            Grid grid = grids[x - 1, y - 1];
            if (grid == null) {
                return false;
            }

            return grid.isHas;
        }

        public Vector2 GetGrid(Vector2 pos) {
            Vector2 grid = new Vector2();
            Vector2 size = grids[0,0].size;
            grid.x = pos.y/size.y;
            grid.y = pos.x/size.x;
            
            return grid;
        }
    }

    public class mapManager {
        Dictionary<int, map> maps = new Dictionary<int, map>();
        private static mapManager instance;
        public static mapManager Instance {
            get {
                if (instance == null) {
                    instance = new mapManager();
                }
                return instance;
            }
        }
        public map GetMapById(int mapId) {
            map m = maps[mapId];
            return m;
        }

        public int GetNowMapCount() {
            return maps.Count;
        }

        public void AddMap(int mapId, map m) {
            bool isExist = maps.ContainsKey(mapId);
            if (isExist) {
                return;
            }
            m.id = mapId;
            maps.Add(mapId, m);
        }


    }
}
