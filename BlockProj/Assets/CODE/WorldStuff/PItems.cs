using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PItems : MonoBehaviour
{

    void Update()
    {
        GameObject[] items;
        items = GameObject.FindGameObjectsWithTag("Item");
        foreach (GameObject item in items)
        {
            item.transform.SetParent(this.gameObject.transform);
        }
    }

/*    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(0.2f);
        while (true)
        {
            GameObject items;
            items = GameObject.FindGameObjectWithTag("Item");
            if (items.transform.parent == this.gameObject.transform)
            {
                Debug.Log("a");
                items.transform.SetParent(this.gameObject.transform);
            }
            yield return waitTime;
        }
    }*/
}
