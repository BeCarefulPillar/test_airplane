using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutBoard : MonoBehaviour {

    public GameObject gameObject;
    public const int widNum = 10;
    public const int lenNum = 6;

    private Vector2 size;
    private SunKang.map m_map;
    private Vector3 fightAreaSize;

    private void DrawRect(Vector2 pos) {
        Debug.DrawLine(new Vector3(pos.x, pos.y, gameObject.transform.position.z), new Vector3(pos.x, pos.y + size.y, gameObject.transform.position.z), new Color(1, 0, 0));
        Debug.DrawLine(new Vector3(pos.x, pos.y + size.y, gameObject.transform.position.z), new Vector3(pos.x + size.x, pos.y + size.y, gameObject.transform.position.z), new Color(1, 0, 0));
        Debug.DrawLine(new Vector3(pos.x + size.x, pos.y + size.y, gameObject.transform.position.z), new Vector3(pos.x + size.x, pos.y, gameObject.transform.position.z), new Color(1, 0, 0));
        Debug.DrawLine(new Vector3(pos.x + size.x, pos.y, gameObject.transform.position.z), new Vector3(pos.x, pos.y, gameObject.transform.position.z), new Color(1, 0, 0));
    }

    // Use this for initialization
    void Start() {
        GameObject fightAreaObject = GameObject.Find("FightArea");
        fightAreaSize = fightAreaObject.GetComponent<SpriteRenderer>().sprite.bounds.size;

        //初始化地图
        size = new Vector2(fightAreaSize.x / widNum, fightAreaSize.y / lenNum);
        Debug.Log(size.x + "   " + size.y);
        m_map = new SunKang.map(lenNum, widNum, size);

        SunKang.mapManager maps = SunKang.mapManager.Instance;
        int count = maps.GetNowMapCount();
        maps.AddMap(count + 1, m_map);


        //if (fightAreaSize.x > 0 && fightAreaSize.y > 0) {
        //    Vector3 scale = new Vector3(size.x * widNum / fightAreaSize.x, size.y * lenNum / fightAreaSize.y, 1);
        //    fightAreaObject.transform.localScale = scale;
        //}
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < widNum; i++) {
            for (int j = 0; j < lenNum; j++) {
                DrawRect(new Vector2(i * size.x + gameObject.transform.position.x - fightAreaSize.x / 2,
                    j * size.y + gameObject.transform.position.y - fightAreaSize.y / 2));
            }
        }
    }
}
