using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightBlock : MonoBehaviour
{
    public Camera cam;
    public GameObject obj;
    public GameObject player;
    GameObject lastObj;

    int lastX;
    int lastY;

    void Start()
    {
        Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = new Vector2(Mathf.RoundToInt(mousepos.x), Mathf.RoundToInt(mousepos.y));
        obj = Instantiate(obj, new Vector2(pos.x, pos.y), Quaternion.identity);
        lastObj = this.obj;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = new Vector2(Mathf.RoundToInt(mousepos.x), Mathf.RoundToInt(mousepos.y));
        if ((player.transform.position.x - pos.x) < 5 && (player.transform.position.x - pos.x) > -5 && (player.transform.position.y - pos.y) < 5 && (player.transform.position.y - pos.y) > -5) {
            if (lastX != pos.x || lastY != pos.y || lastX != pos.x && lastY != pos.y)
            {
                lastObj.GetComponent<SpriteRenderer>().enabled = true;
                Destroy(lastObj);
                lastX = Mathf.RoundToInt(pos.x);
                lastY = Mathf.RoundToInt(pos.y);
                obj = Instantiate(obj, new Vector2(pos.x, pos.y), Quaternion.identity);

                obj.name = "SelectedBlock";
                lastObj = this.obj;
            }
        } else
        {
            lastObj.GetComponent<SpriteRenderer>().enabled = false;
        } 
    }
}
