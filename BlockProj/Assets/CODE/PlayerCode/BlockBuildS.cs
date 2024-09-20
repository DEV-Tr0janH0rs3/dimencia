using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockBuildS : MonoBehaviour
{

    public GameObject player;
    public Camera cam;
    public WorldGeneratorAlpha script;
    public InventoryS invscript;
    public ItemPickup invscript2;
    public GameObject OnOff;
    bool Background = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void EnableButtons()
    {
        Background = !Background;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Background)
        {
            OnOff.GetComponent<TMPro.TextMeshProUGUI>().text = "Off";
        } else
        {
            OnOff.GetComponent<TMPro.TextMeshProUGUI>().text = "On";
        }

        if (Input.GetMouseButton(1))
        {
            Vector3 mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 pos = new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y));
            Vector2 blockup = new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y) + 1);
            Vector2 blockdown = new Vector2(Mathf.Round(mousepos.x), Mathf.Round(mousepos.y) - 1);
            Vector2 blockright = new Vector2(Mathf.Round(mousepos.x) + 1, Mathf.Round(mousepos.y));
            Vector2 blockleft = new Vector2(Mathf.Round(mousepos.x) - 1, Mathf.Round(mousepos.y));
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
            RaycastHit2D blockuphit = Physics2D.Raycast(blockup, Vector2.up, 0f);
            RaycastHit2D blockdownhit = Physics2D.Raycast(blockdown, Vector2.up, 0f);
            RaycastHit2D blockrighthit = Physics2D.Raycast(blockright, Vector2.up, 0f);
            RaycastHit2D blocklefthhit = Physics2D.Raycast(blockleft, Vector2.up, 0f);


            if (hit.collider == null || hit.collider.gameObject.tag == "Item" || hit.collider != null && hit.collider.gameObject.GetComponent<SpriteRenderer>() && hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "BACKGROUNDBLOCK")
            {
                if ((Mathf.RoundToInt(pos.x) - player.transform.position.x) < 5 && (Mathf.RoundToInt(pos.x) - player.transform.position.x) > -5 && (Mathf.RoundToInt(pos.y) - player.transform.position.y) < 5 && (Mathf.RoundToInt(pos.y) - player.transform.position.y) > -5)
                {
                    if (blockuphit.collider != null || blockdownhit.collider != null || blockrighthit.collider != null || blocklefthhit.collider != null)
                    {
                        if (!Background)
                        {
                            switch (invscript.image.parent.gameObject.GetComponent<RawImage>().texture.name)
                            {
                                case "Grass_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.grass, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Stone_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.stone, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Dirt_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.dirt, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Sand_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.sand, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Wood":
                                    RemoveBlockCount();
                                    script.spawnObj(script.wood, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Leaves_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.leaves, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Rose_Texture":
                                    Vector2 pos2 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit2 = Physics2D.Raycast(pos2, Vector2.up, 0f);
                                    if (hit2.collider != null && hit2.collider.gameObject.GetComponent<SpriteRenderer>() && hit2.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Grass_Texture" || hit2.collider != null && hit2.collider.gameObject.GetComponent<SpriteRenderer>() && hit2.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Dirt_Texture")
                                    {
                                        RemoveBlockCount();
                                        script.spawnObj(script.rose, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    }
                                    break;
                                case "Real_Grass_Texture":
                                    Vector2 pos3 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit3 = Physics2D.Raycast(pos3, Vector2.up, 0f);
                                    if (hit3.collider != null && hit3.collider.gameObject.GetComponent<SpriteRenderer>() && hit3.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Grass_Texture" || hit3.collider != null && hit3.collider.gameObject.GetComponent<SpriteRenderer>() && hit3.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Dirt_Texture")
                                    {
                                        RemoveBlockCount();
                                        script.spawnObj(script.treva, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    }
                                    break;
                                case "EndBlock":
                                    RemoveBlockCount();
                                    script.spawnObj(script.endblock, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Lava_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.lava, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Water_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.water, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Coal_Ore":
                                    RemoveBlockCount();
                                    script.spawnObj(script.coal_ore, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Iron_Ore":
                                    RemoveBlockCount();
                                    script.spawnObj(script.iron_ore, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Ruby_Ore":
                                    RemoveBlockCount();
                                    script.spawnObj(script.ruby_ore, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Dynamite_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.dynamite, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Door":
                                    RemoveBlockCount();
                                    script.spawnObj(script.door, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Cactus_Texture":
                                    Vector2 pos4 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit4 = Physics2D.Raycast(pos4, Vector2.up, 0f);
                                    if (hit4.collider != null && hit4.collider.gameObject.GetComponent<SpriteRenderer>() && hit4.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Sand_Texture" || hit4.collider != null && hit4.collider.gameObject.GetComponent<SpriteRenderer>() && hit4.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Cactus_Texture")
                                    {
                                        RemoveBlockCount();
                                        script.spawnObj(script.cactus, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    }
                                    break;
                                case "Torch":
                                    Vector2 pos5 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit5 = Physics2D.Raycast(pos5, Vector2.up, 0f);
                                    if (hit5.collider != null && hit5.collider.gameObject.GetComponent<SpriteRenderer>() && hit5.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name != "Torch")
                                    {
                                    	RemoveBlockCount();
                                    	script.spawnObj(script.torch, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                	}
                                	break;

                                default:
                                    break;

                            }
                        }
                        else if (Background && hit.collider == null)
                        {
                            switch (invscript.image.parent.gameObject.GetComponent<RawImage>().texture.name)
                            {
                                case "Grass_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_grass, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Stone_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_stone, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Dirt_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_dirt, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Sand_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_sand, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Wood":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_wood, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Leaves_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_leaves, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Dynamite_Texture":
                                    RemoveBlockCount();
                                    script.spawnObj(script.dynamite, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Rose_Texture":
                                    Vector2 pos2 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit2 = Physics2D.Raycast(pos2, Vector2.up, 0f);
                                    if (hit2.collider != null)
                                    {
                                        RemoveBlockCount();
                                        script.spawnObj(script.rose, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    }
                                    break;
                                case "Real_Grass_Texture":
                                    Vector2 pos3 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit3 = Physics2D.Raycast(pos3, Vector2.up, 0f);
                                    if (hit3.collider != null)
                                    {
                                        RemoveBlockCount();
                                        script.spawnObj(script.treva, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    }
                                    break;
                                case "EndBlock":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_endblock, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Coal_Ore":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_coal_ore, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Iron_Ore":
                                    RemoveBlockCount();
                                    script.spawnObj(script.b_iron_ore, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Door":
                                    RemoveBlockCount();
                                    script.spawnObj(script.door, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    break;
                                case "Cactus_Texture":
                                    Vector2 pos4 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit4 = Physics2D.Raycast(pos4, Vector2.up, 0f);
                                    if (hit4.collider != null && hit4.collider.gameObject.GetComponent<SpriteRenderer>() && hit4.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Sand_Texture" || hit4.collider != null && hit4.collider.gameObject.GetComponent<SpriteRenderer>() && hit4.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Cactus_Texture")
                                    {
                                        RemoveBlockCount();
                                        script.spawnObj(script.b_cactus, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                    }
                                    break;
                                case "Torch":
                                    Vector2 pos5 = new Vector2(mousepos.x, mousepos.y - 1);
                                    RaycastHit2D hit5 = Physics2D.Raycast(pos5, Vector2.up, 0f);
                                    if (hit5.collider != null && hit5.collider.gameObject.GetComponent<SpriteRenderer>() && hit5.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name != "Torch")
                                    {
                                    	RemoveBlockCount();
                                    	script.spawnObj(script.torch, Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
                                	}
                                	break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }

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
}
