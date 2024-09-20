using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDropS : MonoBehaviour
{
    public InventoryS invscript;
    public ItemPickup invscript2;
    public SpriteRenderer sr;
    public GameObject obj2;
    public GameObject stone, dirt, grass, leaves, rose, sand, wood, coal, iron, endblock, treva, ruby, apple, apple_eaten, apple_seeds, door, cactus, dynamite;
    public Transform parentofitems;

    void RemoveBlockCount()
    {
        switch (invscript.InventorySlot)
        {
            case 1:
                invscript.Text1.GetComponent<Text>().text = (int.Parse(invscript.Text1.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;
            case 2:
                invscript.Text2.GetComponent<Text>().text = (int.Parse(invscript.Text2.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;
            case 3:
                invscript.Text3.GetComponent<Text>().text = (int.Parse(invscript.Text3.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;
            case 4:
                invscript.Text4.GetComponent<Text>().text = (int.Parse(invscript.Text4.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;
            case 5:
                invscript.Text5.GetComponent<Text>().text = (int.Parse(invscript.Text5.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;
            case 6:
                invscript.Text6.GetComponent<Text>().text = (int.Parse(invscript.Text6.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;
            case 7:
                invscript.Text7.GetComponent<Text>().text = (int.Parse(invscript.Text7.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;
            case 8:
                invscript.Text8.GetComponent<Text>().text = (int.Parse(invscript.Text8.GetComponent<Text>().text) - 1).ToString();
                invscript2.IFTHEREIS0();
                break;


            default:
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (sr.flipX == false)
            {
                float itembum = Random.Range(0.3f, 0.9f);
                switch (invscript.image.parent.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Grass_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(grass, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Stone_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(stone, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Dirt_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(dirt, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Sand_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(sand, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Wood":
                        RemoveBlockCount();
                        obj2 = Instantiate(wood, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Leaves_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(leaves, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Rose_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(rose, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Real_Grass_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(treva, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "EndBlock":
                        RemoveBlockCount();
                        obj2 = Instantiate(endblock, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Coal":
                        RemoveBlockCount();
                        obj2 = Instantiate(coal, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Iron":
                        RemoveBlockCount();
                        obj2 = Instantiate(iron, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Ruby":
                        RemoveBlockCount();
                        obj2 = Instantiate(ruby, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Apple":
                        RemoveBlockCount();
                        obj2 = Instantiate(apple, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Apple_Eaten":
                        RemoveBlockCount();
                        obj2 = Instantiate(apple_eaten, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Apple_Seeds":
                        RemoveBlockCount();
                        obj2 = Instantiate(apple_seeds, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Door":
                        RemoveBlockCount();
                        obj2 = Instantiate(door, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Cactus_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(cactus, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Dynamite_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(dynamite, new Vector2(sr.gameObject.transform.position.x + 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;

                    default:
                        break;

                }
            }
            else
            {
                float itembum2 = Random.Range(-0.3f, -0.9f);
                switch (invscript.image.parent.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Grass_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(grass, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Stone_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(stone, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Dirt_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(dirt, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Sand_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(sand, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Wood":
                        RemoveBlockCount();
                        obj2 = Instantiate(wood, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Leaves_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(leaves, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Rose_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(rose, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Real_Grass_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(treva, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "EndBlock":
                        RemoveBlockCount();
                        obj2 = Instantiate(endblock, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Coal":
                        RemoveBlockCount();
                        obj2 = Instantiate(coal, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Iron":
                        RemoveBlockCount();
                        obj2 = Instantiate(iron, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Ruby":
                        RemoveBlockCount();
                        obj2 = Instantiate(ruby, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Apple":
                        RemoveBlockCount();
                        obj2 = Instantiate(apple, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Apple_Eaten":
                        RemoveBlockCount();
                        obj2 = Instantiate(apple_eaten, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Apple_Seeds":
                        RemoveBlockCount();
                        obj2 = Instantiate(apple_seeds, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Door":
                        RemoveBlockCount();
                        obj2 = Instantiate(door, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Cactus_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(cactus, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;
                    case "Dynamite_Texture":
                        RemoveBlockCount();
                        obj2 = Instantiate(dynamite, new Vector2(sr.gameObject.transform.position.x - 1, sr.gameObject.transform.position.y + 0.7f), Quaternion.identity);
                        obj2.GetComponent<Rigidbody2D>().AddForce(new Vector2(itembum2, 0), ForceMode2D.Impulse);
                        obj2.transform.SetParent(parentofitems);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
