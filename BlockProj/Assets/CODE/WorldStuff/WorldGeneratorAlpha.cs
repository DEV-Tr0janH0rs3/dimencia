using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.IO;

public class WorldGeneratorAlpha : MonoBehaviour
{
    public GameObject player;
    public Camera mcamera;
    public int worldSize = 100;
    public float heightMultiplier = 100f;
    public int heightAddition = 25;
    public float terrainFreq = 0.03f;
    public float caveFreq = 0.05f;
    public float watercaveFreq = 0.02f;
    [SerializeField] int minIronHeight, maxIronHeight;
    [SerializeField] int minRubyHeight, maxRubyHeight;
    public GameObject dirt, grass, stone, endblock, water, sand, coal_ore, iron_ore, wood, ruby_ore, ore_stone, door, lava, dynamite,torch; //BLOCKS

    [Header("Background Blocks")]
    public GameObject b_dirt;
    public GameObject b_grass, b_stone, b_endblock, b_sand, b_coal_ore, b_iron_ore, b_wood, b_leaves, b_ruby_ore, b_ore_stone, b_cactus; //BACKGROUND BLOCKS
    public GameObject actualBackground;

    [Space]
    [Header("Vegetation")]
    public GameObject tree;
    public GameObject darktree;
    public GameObject treva, rose, leaves, cactus, dead_grass, snowlayer; //Spawnable
    [Space(10)]
    public int seed;
    public Texture2D noiseTex;
    public Texture2D biomeTex;

    public GameObject[] worldChunks;

    [Header("Biomes")]
    public float biomeFreq;

    WorldGen noise;


    // Start is called before the first frame update
    void Start()
    {
        seed = Random.Range(-10000000, 10000000);
        GenNoise();
        CreateChunks();
        BiomeNoise();
        CreateWorld();
        Unstuck();
        RefreshChunks();
    }

    void Update()
    {
        RefreshChunks();
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void CreateChunks()
    {
        int numChunks = worldSize / 16;
        worldChunks = new GameObject[numChunks];

        for(int i = 0; i < numChunks; i++)
        {
            GameObject newChunk = new GameObject();
            newChunk.name = i.ToString();
            newChunk.transform.parent = this.transform;
            worldChunks[i] = newChunk;
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void Unstuck(){
        GameObject[] plants;
        plants = GameObject.FindGameObjectsWithTag("Plant");
        foreach (GameObject plant in plants)
        {
            Vector2 posit = new Vector2(plant.transform.position.x, plant.transform.position.y);
            RaycastHit2D hita = Physics2D.Raycast(posit, Vector2.up, 0f);

            if(hita.collider != null && hita.collider.gameObject != plant && hita.collider.gameObject.tag != "Plant"){
                plant.transform.position = new Vector2(plant.transform.position.x, plant.transform.position.y + 1);
            }
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void CreateWorld()
    {

        for(int x = 0; x < worldSize; x++)
        {
            spawnObj(endblock, x, -1);
        }

        GameObject block;
        for (int x = 0; x < worldSize; x++)
        {
            float height = Mathf.PerlinNoise((x + seed) * terrainFreq, seed * terrainFreq) * heightMultiplier + heightAddition;
            for (int y = 0; y < height; y++)
            {
                int dirtrandom = Random.Range(4, 8);

                if (y < height - dirtrandom)
                {
                    int RubySpawn = Random.Range(1, 120);
                    int IronSpawn = Random.Range(1, 69);
                    int CoalSpawn = Random.Range(1, 50);
                    if (CoalSpawn == 24)
                    {
                        block = coal_ore;
                    }
                    else if (IronSpawn == 25 && y > minIronHeight && y < maxIronHeight)
                    {
                        block = iron_ore;
                    }
                    else if (RubySpawn == 73 && y >= minRubyHeight && y <= maxRubyHeight)
                    {
                        block = ruby_ore;
                    }
                    else
                    {
                        block = stone;
                    }
                } else if (y < height - 1)
                {
                    if (biomeTex.GetPixel(x, y).r < 0.42f && biomeTex.GetPixel(x, y).r > 0.21f)
                    {
                        block = sand;
                    } 
                    else
                    {
                        block = dirt;
                    }
                } else
                {
                    if (biomeTex.GetPixel(x, y).r < 0.42f && biomeTex.GetPixel(x, y).r > 0.21f)
                    {
                        block = sand;
                    }
                    else
                    {
                        block = grass;
                    }

                    if (biomeTex.GetPixel(x, y).r < 0.21f){
                    	spawnObj(snowlayer, x, y + 1);
                    }
                }


                if (noiseTex.GetPixel(x, y).r > 0.2f)
                {
                    spawnObj(block, x, y);
                    //File.AppendAllText(@"C:\Users\Tr0janH0rs3\Desktop\chunk1.txt","\r\n" + block + "," + x + "," + y);
                } else
                {
                    int IronSpawn = Random.Range(1, 69);
                    int CoalSpawn = Random.Range(1, 50);
                    int RubySpawn = Random.Range(1, 120);
                    if (CoalSpawn == 24)
                    {
                        spawnObj(b_coal_ore,x ,y);
                    }
                    else if (IronSpawn == 25 && y > minIronHeight && y < maxIronHeight)
                    {
                        spawnObj(b_iron_ore, x, y);
                    }
                    else if (RubySpawn == 73 && y >= minRubyHeight && y <= maxRubyHeight)
                    {
                        spawnObj(b_ruby_ore,x,y);
                    }
                    else
                    {
                        spawnObj(b_stone, x, y);
                    }
                }




                int TreeSpawn = Random.Range(1, 500);
                int DarkTreeSpawn = Random.Range(1, 25);
                if (TreeSpawn == 56)
                {
                    Vector2 pos = new Vector2(x, Mathf.RoundToInt(height));
                    RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
                    if (hit.collider != null || hit.collider != null && hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName != "BACKGROUNDBLOCK")
                    {
                        if (biomeTex.GetPixel(x, y).r > 0.42f)
                        {
                            spawnObj(tree, x, Mathf.RoundToInt(height));
                        }
						if (biomeTex.GetPixel(x, y).r < 0.21f)
                        {
                            spawnObj(darktree, x, Mathf.RoundToInt(height));
                        }
                    }
                }
				if (DarkTreeSpawn == 6)
                {
                    Vector2 pos = new Vector2(x, Mathf.RoundToInt(height));
                    RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
                    if (hit.collider != null || hit.collider != null && hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName != "BACKGROUNDBLOCK")
                    {
						if (biomeTex.GetPixel(x, y).r < 0.21f)
                        {
                            spawnObj(darktree, x, Mathf.RoundToInt(height));
                        }
                    }
                }
                int RasteniqSpawn = Random.Range(1, 400);
                if (RasteniqSpawn == 47 || RasteniqSpawn == 59 || RasteniqSpawn == 69 || RasteniqSpawn == 142)
                {
                    if (biomeTex.GetPixel(x, y).r > 0.42f)
                    { 
                        spawnObj(treva, x, Mathf.RoundToInt(height));
                    }
                }

                if (RasteniqSpawn == 333)
                {
                    if (biomeTex.GetPixel(x, y).r < 0.42f && biomeTex.GetPixel(x, y).r > 0.21f)
                    {
                        spawnObj(b_cactus, x, Mathf.RoundToInt(height));
                    } 
                }

                if (RasteniqSpawn == 369)
                {
                    if (biomeTex.GetPixel(x, y).r < 0.42f && biomeTex.GetPixel(x, y).r > 0.21f)
                    {
                        spawnObj(dead_grass, x, Mathf.RoundToInt(height));
                    }
                }

                if (RasteniqSpawn == 272)
                {
                    if (biomeTex.GetPixel(x, y).r > 0.42f)
                    {
                        spawnObj(rose, x, Mathf.RoundToInt(height));
                    }
                }

            }
        }
        for(int x = 0; x < worldSize; x++)
        {
            for(int y = 0; y < 100; y++)
            {
                if (y < 76 && y > 65)
                {
                    Vector2 pos = new Vector2(x, y);
                    RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
                    if (hit.collider == null)
                    {
                        spawnObj(water, x, y);
                    }
                }
				if (y > 0 && y < 10)
                {
                    Vector2 pos = new Vector2(x, y);
                    RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
                    if (hit.collider == null || hit.collider != null && hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "BACKGROUNDBLOCK")
                    {
                        spawnObj(lava, x, y);
                    }
                }
            }
        }
        for (int x = 0; x < worldSize; x++)
        {
            for (int y = 0; y < 100; y++)
            {
                if (y < 74)
                {
                    Vector2 pos = new Vector2(x, y);
                    RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.up, 0f);
                    if (hit.collider != null)
                    {
                        if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "Tree")
                        {
                            Destroy(hit.collider.gameObject.transform.parent.gameObject);
                        }
                        if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sortingLayerName == "Rasteniq")
                        {
                            Destroy(hit.collider.gameObject);
                        }
                        if (hit.collider.gameObject.GetComponent<SpriteRenderer>().sprite.texture.name == "Grass_Texture")
                        {
                            int minHeight = y;
                            int maxHeight = y + 2;
                            int spawnsandmore = Random.Range(minHeight, maxHeight);
                            Destroy(hit.collider.gameObject);
                            spawnObj(sand, x, y);
                            int SandSpawn = Random.Range(1, 5);
                            if (SandSpawn == 3 || SandSpawn == 2)
                            {
                                spawnObj(sand, x, spawnsandmore);
                            }
                        }
                    }
                }
            }
        }
    }
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    void RefreshChunks()
    {
        for(int i = 0; i < worldChunks.Length; i++)
        {
            if (Vector2.Distance(new Vector2((i * 16) + (16 / 2), 0), new Vector2(player.transform.position.x, 0)) > mcamera.orthographicSize * 3f)
            {
                worldChunks[i].SetActive(false);
            }
            else
            {
                worldChunks[i].SetActive(true);
            }
        }
    }

    public void GenNoise()
    {
        noiseTex = new Texture2D(worldSize, worldSize);
        for(int x = 0; x < noiseTex.width; x++)
        {
            for(int y = 0; y < noiseTex.height; y++)
            {
                float v = Mathf.PerlinNoise((x + seed) * caveFreq, (y + seed) * caveFreq);
                noiseTex.SetPixel(x, y, new Color(v, v, v));
                float f = Mathf.PerlinNoise((x + seed) * watercaveFreq, (y + seed) * watercaveFreq);
                noiseTex.SetPixel(x, y, new Color(f, f, f));
            }
        }
        noiseTex.Apply();
    }
    public void BiomeNoise()
    {
        biomeTex = new Texture2D(worldSize, worldSize);
        for (int x = 0; x < biomeTex.width; x++)
        {
            for (int y = 0; y < biomeTex.height; y++)
            {
                float v = Mathf.PerlinNoise((x + seed) * biomeFreq, seed * biomeFreq);
                biomeTex.SetPixel(x, y, new Color(v, v, v));

            }
        }
        biomeTex.Apply();
    }
    

    public void spawnObj(GameObject obj, int width, int height)
    {
        float chunkCoord = (Mathf.Round(width / 16) * 16);
        chunkCoord /= 16;
        obj = Instantiate(obj, new Vector2(width, height), Quaternion.identity);
        obj.transform.parent = worldChunks[(int)chunkCoord].transform;
/*        if(worldChunks[(int)chunkCoord].name == "0"){
            File.AppendAllText(@"C:\Users\Tr0janH0rs3\Desktop\chunk1.txt","\r\n" + width + "," + height);
        }*/
        obj.name = "Block";
    }


}
