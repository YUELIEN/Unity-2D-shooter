using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottom_Side_Function : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col) //碰撞事件
    {
        if (col.tag == "Emeny") //如果標籤是Emeny
        {
            Destroy(col.gameObject); //消滅碰撞的物件
        }
    }
}
