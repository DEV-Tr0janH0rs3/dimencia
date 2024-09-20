using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.IO;
using System;

public class TestNewGeneration : MonoBehaviour
{
	public WorldGeneratorAlpha wga;
	public string block;
	public string liniq;
	public int x;
	public int y;
	public List<string> blokove = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
/*        ThreadStart threada = new ThreadStart(testa);
        Thread qktredbrat = new Thread(threada);
        qktredbrat.Start();*/
        testa();
    }

    void Update(){

    }



    public void testa(){
		int counter = 0;  
  
		// Read the file and display it line by line.  
		foreach (string line in System.IO.File.ReadLines(@"C:\Users\Tr0janH0rs3\Desktop\chunk1.txt"))
		{
			blokove.Add(line);
   			counter++;  
		} 
		for(int i = 0; i < counter; i++){
			string dadeniqblok = blokove[i];
			string[] splitnati = dadeniqblok.Split(',');
			wga.spawnObj(wga.stone,int.Parse(splitnati[0].ToString()), int.Parse(splitnati[1].ToString()));
		}
  
    }
}
