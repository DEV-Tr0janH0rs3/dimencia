using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public InventoryS invscript;
    public GameObject text;
    public CapsuleCollider2D player;
    public bool isFull = false;
    public GameObject tcollision;

    public void IFTHEREIS0()
    {
        if (int.Parse(invscript.Text1.GetComponent<Text>().text) == 0)
        {
            invscript.Slot1.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot1.gameObject.tag = "Empty";
            invscript.Text1.SetActive(false);
        }
        if (int.Parse(invscript.Text2.GetComponent<Text>().text) == 0)
        {
            invscript.Slot2.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot2.gameObject.tag = "Empty";
            invscript.Text2.SetActive(false);
        }
        if (int.Parse(invscript.Text3.GetComponent<Text>().text) == 0)
        {
            invscript.Slot3.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot3.gameObject.tag = "Empty";
            invscript.Text3.SetActive(false);
        }
        if (int.Parse(invscript.Text4.GetComponent<Text>().text) == 0)
        {
            invscript.Slot4.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot4.gameObject.tag = "Empty";
            invscript.Text4.SetActive(false);
        }
        if (int.Parse(invscript.Text5.GetComponent<Text>().text) == 0)
        {
            invscript.Slot5.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot5.gameObject.tag = "Empty";
            invscript.Text5.SetActive(false);
        }
        if (int.Parse(invscript.Text6.GetComponent<Text>().text) == 0)
        {
            invscript.Slot6.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot6.gameObject.tag = "Empty";
            invscript.Text6.SetActive(false);
        }
        if (int.Parse(invscript.Text7.GetComponent<Text>().text) == 0)
        {
            invscript.Slot7.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot7.gameObject.tag = "Empty";
            invscript.Text7.SetActive(false);
        }
        if (int.Parse(invscript.Text8.GetComponent<Text>().text) == 0)
        {
            invscript.Slot8.GetComponent<RawImage>().texture = invscript.Nothing.GetComponent<RawImage>().texture;
            invscript.Slot8.gameObject.tag = "Empty";
            invscript.Text8.SetActive(false);
        }
    }

    void Check1()
    {
        switch (invscript.Slot1.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text1.GetComponent<Text>().text = (int.Parse(invscript.Text1.GetComponent<Text>().text) + 1).ToString();
                break;
            default:
                Check2();
                break;
        }
    }
    void Check2()
    {
        switch (invscript.Slot2.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text2.GetComponent<Text>().text = (int.Parse(invscript.Text2.GetComponent<Text>().text) + 1).ToString();
                break;
            default:
                Check3();
                break;
        }
    }
    void Check3()
    {
        switch (invscript.Slot3.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text3.GetComponent<Text>().text = (int.Parse(invscript.Text3.GetComponent<Text>().text) + 1).ToString();
                break;
            default:
                Check4();
                break;
        }
    }
    void Check4()
    {
        switch (invscript.Slot4.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text4.GetComponent<Text>().text = (int.Parse(invscript.Text4.GetComponent<Text>().text) + 1).ToString();
                break;
            default:
                Check5();
                break;
        }
    }
    void Check5()
    {
        switch (invscript.Slot5.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text5.GetComponent<Text>().text = (int.Parse(invscript.Text5.GetComponent<Text>().text) + 1).ToString();
                break;
            default:
                Check6();
                break;
        }
    }
    void Check6()
    {
        switch (invscript.Slot6.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text6.GetComponent<Text>().text = (int.Parse(invscript.Text6.GetComponent<Text>().text) + 1).ToString();
                break;
            default:
                Check7();
                break;
        }
    }
    void Check7()
    {
        switch (invscript.Slot7.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text7.GetComponent<Text>().text = (int.Parse(invscript.Text7.GetComponent<Text>().text) + 1).ToString();
                break;

            default:
                Check8();
                break;
        }
    }
    void Check8()
    {
        switch (invscript.Slot8.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
        {
            case true:
                Destroy(tcollision.gameObject);
                invscript.Text8.GetComponent<Text>().text = (int.Parse(invscript.Text8.GetComponent<Text>().text) + 1).ToString();
                break;
            default:
                if (invscript.Slot8.gameObject.tag == "Empty" && invscript.Slot7.gameObject.tag != "Empty" && invscript.Slot6.gameObject.tag != "Empty" && invscript.Slot5.gameObject.tag != "Empty" && invscript.Slot4.gameObject.tag != "Empty" && invscript.Slot3.gameObject.tag != "Empty" && invscript.Slot2.gameObject.tag != "Empty" && invscript.Slot1.gameObject.tag != "Empty"
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot1.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot2.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot3.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot4.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot5.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot6.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot7.GetComponent<RawImage>().texture
                )
                {
                    invscript.Slot8.gameObject.tag = "NotEmpty";
                    invscript.Slot8.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text8.SetActive(true);
                    invscript.Text8.GetComponent<Text>().text = (int.Parse(invscript.Text8.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (invscript.Slot8.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text8.GetComponent<Text>().text = (int.Parse(invscript.Text8.GetComponent<Text>().text) + 1).ToString();
                    }
                }

                if (invscript.Slot7.gameObject.tag == "Empty" && invscript.Slot6.gameObject.tag != "Empty" && invscript.Slot5.gameObject.tag != "Empty" && invscript.Slot4.gameObject.tag != "Empty" && invscript.Slot3.gameObject.tag != "Empty" && invscript.Slot2.gameObject.tag != "Empty" && invscript.Slot1.gameObject.tag != "Empty"
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot1.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot2.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot3.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot4.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot5.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot6.GetComponent<RawImage>().texture
                    )
                {
                    invscript.Slot7.gameObject.tag = "NotEmpty";
                    invscript.Slot7.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text7.SetActive(true);
                    invscript.Text7.GetComponent<Text>().text = (int.Parse(invscript.Text7.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (invscript.Slot7.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text7.GetComponent<Text>().text = (int.Parse(invscript.Text7.GetComponent<Text>().text) + 1).ToString();
                    }
                }

                if (invscript.Slot6.gameObject.tag == "Empty" && invscript.Slot5.gameObject.tag != "Empty" && invscript.Slot4.gameObject.tag != "Empty" && invscript.Slot3.gameObject.tag != "Empty" && invscript.Slot2.gameObject.tag != "Empty" && invscript.Slot1.gameObject.tag != "Empty"
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot1.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot2.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot3.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot4.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot5.GetComponent<RawImage>().texture
                    )
                {
                    invscript.Slot6.gameObject.tag = "NotEmpty";
                    invscript.Slot6.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text6.SetActive(true);
                    invscript.Text6.GetComponent<Text>().text = (int.Parse(invscript.Text6.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (invscript.Slot6.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text6.GetComponent<Text>().text = (int.Parse(invscript.Text6.GetComponent<Text>().text) + 1).ToString();
                    }
                }


                if (invscript.Slot5.gameObject.tag == "Empty" && invscript.Slot4.gameObject.tag != "Empty" && invscript.Slot3.gameObject.tag != "Empty" && invscript.Slot2.gameObject.tag != "Empty" && invscript.Slot1.gameObject.tag != "Empty"
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot1.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot2.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot3.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot4.GetComponent<RawImage>().texture
                    )
                {
                    invscript.Slot5.gameObject.tag = "NotEmpty";
                    invscript.Slot5.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text5.SetActive(true);
                    invscript.Text5.GetComponent<Text>().text = (int.Parse(invscript.Text5.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (invscript.Slot5.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text5.GetComponent<Text>().text = (int.Parse(invscript.Text5.GetComponent<Text>().text) + 1).ToString();
                    }
                }

                if (invscript.Slot4.gameObject.tag == "Empty" && invscript.Slot3.gameObject.tag != "Empty" && invscript.Slot2.gameObject.tag != "Empty" && invscript.Slot1.gameObject.tag != "Empty"
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot1.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot2.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot3.GetComponent<RawImage>().texture
                    )
                {
                    invscript.Slot4.gameObject.tag = "NotEmpty";
                    invscript.Slot4.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text4.SetActive(true);
                    invscript.Text4.GetComponent<Text>().text = (int.Parse(invscript.Text4.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (invscript.Slot4.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text4.GetComponent<Text>().text = (int.Parse(invscript.Text4.GetComponent<Text>().text) + 1).ToString();
                    }
                }

                if (invscript.Slot3.gameObject.tag == "Empty" && invscript.Slot2.gameObject.tag != "Empty" && invscript.Slot1.gameObject.tag != "Empty"
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot1.GetComponent<RawImage>().texture
                    && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot2.GetComponent<RawImage>().texture
                    )
                {
                    invscript.Slot3.gameObject.tag = "NotEmpty";
                    invscript.Slot3.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text3.SetActive(true);
                    invscript.Text3.GetComponent<Text>().text = (int.Parse(invscript.Text3.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (invscript.Slot3.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text3.GetComponent<Text>().text = (int.Parse(invscript.Text3.GetComponent<Text>().text) + 1).ToString();
                    }
                }

                if (invscript.Slot2.gameObject.tag == "Empty" && invscript.Slot1.gameObject.tag != "Empty" && tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture != invscript.Slot1.GetComponent<RawImage>().texture)
                {
                    invscript.Slot2.gameObject.tag = "NotEmpty";
                    invscript.Slot2.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text2.SetActive(true);
                    invscript.Text2.GetComponent<Text>().text = (int.Parse(invscript.Text2.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (invscript.Slot2.GetComponent<RawImage>().texture == tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text2.GetComponent<Text>().text = (int.Parse(invscript.Text2.GetComponent<Text>().text) + 1).ToString();
                    }
                }

                if (invscript.Slot1.gameObject.tag == "Empty")
                {
                    invscript.Slot1.gameObject.tag = "NotEmpty";
                    invscript.Slot1.GetComponent<RawImage>().texture = tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture;
                    Destroy(tcollision.gameObject);
                    invscript.Text1.SetActive(true);
                    invscript.Text1.GetComponent<Text>().text = (int.Parse(invscript.Text1.GetComponent<Text>().text) + 1).ToString();
                }
                else
                {
                    if (tcollision.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite.texture == invscript.Slot1.GetComponent<RawImage>().texture)
                    {
                        Destroy(tcollision.gameObject);
                        invscript.Text1.GetComponent<Text>().text = (int.Parse(invscript.Text1.GetComponent<Text>().text) + 1).ToString();
                    }
                }
                break;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            if (player.IsTouching(collision.gameObject.GetComponent<BoxCollider2D>()))
            {
                tcollision = collision.gameObject;
                Check1();
            }
        }
    }
}


