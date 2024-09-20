using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{

	public float GameTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InfiniteLoop());
    }
    void OnEnable()
    {
        StartCoroutine(InfiniteLoop());
    }

    void Update(){
    	if(GameTime == 1201){
    		GameTime = 0;
    	}
        if(GameTime < 0){
            GameTime = 0;
        }
    }

    private IEnumerator InfiniteLoop()
    {
        WaitForSeconds waitTime = new WaitForSeconds(.8f);
        while (true)
        {
        	GameTime = GameTime + 0.5f; 
        yield return waitTime;
        }
    }

}
