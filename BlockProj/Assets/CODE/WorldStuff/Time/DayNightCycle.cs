using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
	public TimeScript timescript;
	public GameObject SunLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timescript.GameTime > 512f && timescript.GameTime < 600){
        	SunLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 1.00f - ((timescript.GameTime - 511f) / 100f); 
        }
        if(timescript.GameTime >= 600 && timescript.GameTime < 1111){
        	SunLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0.12f;
        }
        if(timescript.GameTime >= 0 && timescript.GameTime < 511){
        	SunLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 1.0f;
        }
        if(timescript.GameTime > 1112f && timescript.GameTime < 1200f){
        	SunLight.GetComponent<UnityEngine.Rendering.Universal.Light2D>().intensity = 0.12f + ((timescript.GameTime - 1111f) / 100f);
        }
    }
}
