using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugInfo : MonoBehaviour
{
     public GameObject txtFps;
     public GameObject txtLoc;
     public GameObject txtSeed;
     public GameObject debuger;
     public WorldGeneratorAlpha wg;
 
     public float updateRateSeconds = 4.0F;
 
     int frameCount = 0;
     float dt = 0.0F;
     float fps = 0.0F;

     void Start(){
        txtSeed.GetComponent<Text>().text = ("SEED: " + wg.seed);
     }
 
     void Update()
     {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!debuger.activeSelf)
            {
                debuger.SetActive(true);
            } else
            {
                debuger.SetActive(false);
            }
        }

            frameCount++;
         dt += Time.unscaledDeltaTime;
         if (dt > 1.0 / updateRateSeconds)
         {
             fps = frameCount / dt;
             frameCount = 0;
             dt -= 1.0F / updateRateSeconds;
         }
        txtFps.GetComponent<Text>().text = ("FPS: " + Mathf.RoundToInt(fps));
        txtLoc.GetComponent<Text>().text = ("X: " + Mathf.RoundToInt(this.gameObject.transform.position.x) + " Y: " + Mathf.RoundToInt(this.gameObject.transform.position.y - 2));
     }
 }