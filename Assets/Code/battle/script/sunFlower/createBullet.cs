using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBullet : MonoBehaviour {
    private Transform fatherTrans;
    private SunKang.bulletBase bullet;
    private float coolDownTime;
    private List<GameObject> bulletObjs;
    
    public GameObject bulletObj;
    public float speed;
    public float coolDown;
	// Use this for initialization
	void Start () {
        fatherTrans = GameObject.Find("FightArea").transform;
        bullet = new SunKang.bulletBase(speed, coolDown);
        bulletObj.GetComponent<bullet>().speed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        coolDownTime += Time.deltaTime;
        if(coolDownTime > coolDown) {
            coolDownTime = 0;
            GameObject obj = Instantiate(bulletObj, gameObject.transform.position, 
                bulletObj.transform.rotation, fatherTrans);
        }
    }
}
