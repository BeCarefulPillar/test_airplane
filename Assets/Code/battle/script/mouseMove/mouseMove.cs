using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour {
    private Vector3 mousePosition, targetPosition;
    private Transform fatherTrans;
    private string prefabPaht = "Prefabs/";
    private Transform myPrefab;
    private Vector3 fightAreaSize;
    private Sunkang.map map;

    public GameObject obj;
    public string prefabName = "SunFlower";
    public int mapId = 1;
    // Use this for initialization
    void Start() {
        fatherTrans = GameObject.Find("FightArea").transform;
        myPrefab = ((GameObject)Resources.Load(prefabPaht + prefabName)).transform;
        fightAreaSize = fatherTrans.GetComponent<SpriteRenderer>().sprite.bounds.size;

        obj = Instantiate(obj, fatherTrans);
        obj.SetActive(false);

        Sunkang.mapManager maps = Sunkang.mapManager.Instance;
        map = maps.GetMapById(1);
    }

    // Update is called once per frame
    void Update() {
        mousePosition = Input.mousePosition;
        Vector3 pos = Camera.main.WorldToViewportPoint(fatherTrans.position);
        targetPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, pos.z));
        transform.position = targetPosition;
        myPrefab.position = targetPosition;

        Vector2 pos2d = new Vector2(targetPosition.x + fightAreaSize.x / 2, targetPosition.y + fightAreaSize.y / 2);
        Vector2 grid = map.GetGrid(pos2d);

        if (grid.x >= 0 && grid.y >= 0 && grid.x < map.grids.GetLength(0) && grid.y < map.grids.GetLength(1)) {
            int x = (int)grid.x;
            int y = (int)grid.y;
            obj.SetActive(true);
            obj.transform.position = new Vector3(y * map.grids[x, y].size.x + map.grids[x, y].size.x / 2 - fightAreaSize.x / 2,
                x * map.grids[x, y].size.y + map.grids[x, y].size.y / 2 - fightAreaSize.y / 2,
                obj.transform.position.z);
            if (Input.GetMouseButtonUp(0)) {
                if (!map.grids[x, y].isHas) {
                    Instantiate(myPrefab, obj.transform.position, myPrefab.rotation, fatherTrans);
                    map.grids[x, y].isHas = true;
                }
                Destroy(obj);
                Destroy(gameObject);
            }
        } else {
            obj.SetActive(false);
            if (Input.GetMouseButtonUp(0)) {
                Destroy(obj);
                Destroy(gameObject);
            }

        }

    }


}
