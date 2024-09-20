using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryS : MonoBehaviour
{
    public Transform image;
    public Transform Slot1;
    public Transform Slot2;
    public Transform Slot3;
    public Transform Slot4;
    public Transform Slot5;
    public Transform Slot6;
    public Transform Slot7;
    public Transform Slot8;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;
    public GameObject Nothing;
    public int InventorySlot;

    Vector3 slot1 = new Vector3(0f, 0f, 0f);
    Vector3 slot2 = new Vector3(0f, 0f, 0f);
    Vector3 slot3 = new Vector3(0f, 0f, 0f);
    Vector3 slot4 = new Vector3(0f, 0f, 0f);
    Vector3 slot5 = new Vector3(0f, 0f, 0f);
    Vector3 slot6 = new Vector3(0f, 0f, 0f);
    Vector3 slot7 = new Vector3(0f, 0f, 0f);
    Vector3 slot8 = new Vector3(0f, 0f, 0f);


    // Start is called before the first frame update
    void Start()
    {
        InventorySlot = 1;
        image.transform.SetParent(Slot1);
        image.GetComponent<RectTransform>().localPosition = slot1;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("1"))
        {
            InventorySlot = 1;  
            image.transform.SetParent(Slot1);
            image.GetComponent<RectTransform>().localPosition = slot1;
        } else if (Input.GetKeyDown("2"))
        {
            InventorySlot = 2;
            image.transform.SetParent(Slot2);
            image.GetComponent<RectTransform>().localPosition = slot2;
        }
        else if (Input.GetKeyDown("3"))
        {
            InventorySlot = 3;
            image.transform.SetParent(Slot3);
            image.GetComponent<RectTransform>().localPosition = slot3;
        }
        else if (Input.GetKeyDown("4"))
        {
            InventorySlot = 4;
            image.transform.SetParent(Slot4);
            image.GetComponent<RectTransform>().localPosition = slot4;
        }
        else if (Input.GetKeyDown("5"))
        {
            InventorySlot = 5;
            image.transform.SetParent(Slot5);
            image.GetComponent<RectTransform>().localPosition = slot5;
        }
        else if (Input.GetKeyDown("6"))
        {
            InventorySlot = 6;
            image.transform.SetParent(Slot6);
            image.GetComponent<RectTransform>().localPosition = slot6;
        }
        else if (Input.GetKeyDown("7"))
        {
            InventorySlot = 7;
            image.transform.SetParent(Slot7);
            image.GetComponent<RectTransform>().localPosition = slot7;
        }
        else if (Input.GetKeyDown("8"))
        {
            InventorySlot = 8;
            image.transform.SetParent(Slot8);
            image.GetComponent<RectTransform>().localPosition = slot8;
        }
    }
}
