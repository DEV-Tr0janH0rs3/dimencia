using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInHandS : MonoBehaviour
{
    public InventoryS invscript;
    public Sprite dirt, grass, stone, endblock, water, sand, door, coal_ore, iron_ore, wood, leaves, treva, rose, ruby_ore, ruby, iron, coal, apple, apple_eaten, apple_seeds, nothing, cactus;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (invscript.InventorySlot)
        {
            case 1:
                switch (invscript.Slot1.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
            case 2:
                switch (invscript.Slot2.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
            case 3:
                switch (invscript.Slot3.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
            case 4:
                switch (invscript.Slot4.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
            case 5:
                switch (invscript.Slot5.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
            case 6:
                switch (invscript.Slot6.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
            case 7:
                switch (invscript.Slot7.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
            case 8:
                switch (invscript.Slot8.gameObject.GetComponent<RawImage>().texture.name)
                {
                    case "Door":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = door;
                        break;
                    case "Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = grass;
                        break;
                    case "Dirt_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = dirt;
                        break;
                    case "Tall_Grass_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = treva;
                        break;
                    case "Stone_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = stone;
                        break;
                    case "Wood":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = wood;
                        break;
                    case "Leaves_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = leaves;
                        break;
                    case "Sand_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = sand;
                        break;
                    case "Rose_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = rose;
                        break;
                    case "Iron_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron_ore;
                        break;
                    case "Coal_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal_ore;
                        break;
                    case "Ruby_Ore":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby_ore;
                        break;
                    case "Coal":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = coal;
                        break;
                    case "Iron":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = iron;
                        break;
                    case "Ruby":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = ruby;
                        break;
                    case "Apple":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple;
                        break;
                    case "Apple_Eaten":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_eaten;
                        break;
                    case "Apple_Seeds":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = apple_seeds;
                        break;
                    case "Water_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = water;
                        break;
                    case "EndBlock":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = endblock;
                        break;
                    case "Cactus_Texture":
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = cactus;
                        break;
                    default:
                        this.gameObject.GetComponent<SpriteRenderer>().sprite = nothing;
                        break;
                }
                break;
        }

    }
}
