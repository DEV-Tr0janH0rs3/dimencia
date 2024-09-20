using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDespawn : MonoBehaviour
{
    void Update()
    {
        if(this.gameObject.transform.position.y < -15){
        	Destroy(this.gameObject);
        }
    }
}
