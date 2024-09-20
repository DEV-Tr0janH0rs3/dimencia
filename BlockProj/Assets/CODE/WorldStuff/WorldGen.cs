using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGen 
{
    long seed;

    public WorldGen(long seed)
    {
        this.seed = seed;
    }

    private int random(int x, int range)
    {
        return (int)((x + seed) ^ 5) % range;
    }

    public int getNoise(int x, int range)
    {
        int chunkSize = 16;

        int chunkIndex = x / 16;

        float prog = (x % chunkSize) / (chunkSize * 1f);

        float left_Random = random(chunkIndex, range);
        float right_Random = random(chunkIndex + 1, range);

        float noise = (1 - prog) * left_Random + prog * right_Random;

        return (int)Mathf.Round(noise);

    }
}
