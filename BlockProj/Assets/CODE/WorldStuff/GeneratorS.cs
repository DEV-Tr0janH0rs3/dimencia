using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorS : MonoBehaviour
{
    public WorldGeneratorAlpha scripta;
    [SerializeField] int width , height;
    [SerializeField] int minStoneHeight, maxStoneHeight;
    [SerializeField] int minIronHeight, maxIronHeight;
    [SerializeField] int minRubyHeight, maxRubyHeight;
    public GameObject dirt, grass, stone, endblock, water, sand, coal_ore, iron_ore, wood, ruby_ore, ore_stone, door, lava, dynamite; //BLOCKS
    [Header("Background Blocks")]
    public GameObject b_dirt;
    public GameObject b_grass, b_stone, b_endblock, b_sand, b_coal_ore, b_iron_ore, b_wood, b_leaves, b_ruby_ore, b_ore_stone, b_cactus; //BACKGROUND BLOCKS
    [Space]
    [Header("Vegetation")]
    public GameObject tree;
    public GameObject treva, rose, leaves, cactus; //Spawnable
    [Space(10)]
    [SerializeField] float heightValue, smoothTerrain;

    WorldGen noise;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void spawnObj(GameObject obj, float width, float height)
    {
        float chunkCoord = (Mathf.Round(256 / 16) * 16);
        chunkCoord /= 16;
        obj = Instantiate(obj, new Vector2(width, height), Quaternion.identity);
        obj.transform.parent = scripta.worldChunks[(int)chunkCoord].transform;
        obj.name = "Block";
    }

}
