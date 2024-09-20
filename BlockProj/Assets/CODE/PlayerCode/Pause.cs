using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	bool PAUSED;
	public GameObject PAUSEMENU;
	public BlockBreakS blockbreak;
    public GameObject Chat;
	public BlockBuildS blockbuild;
	public ItemDropS itemdrop;
	public ChatScript chatscript ;
	public OpenThings openthings;
	public HighlightBlock hgb;
	public DebugInfo debug;
	public PlayerMovement playermove;
    // Start is called before the first frame update
    void Start()
    {
        PauseGame();
        PauseGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { 
        	PauseGame();
        }
    }

    public void ExitWorld(){
    	SceneManager.UnloadSceneAsync("SurvivalGame");
    	SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void PauseGame(){
    	if(!PAUSED){
    		PAUSED = true;
    		Time.timeScale = 0;
    		blockbreak.enabled = false;
    		blockbuild.enabled = false;
    		itemdrop.enabled = false;
    		chatscript.enabled = false;
    		openthings.enabled = false;
    		hgb.enabled = false;
    		debug.enabled = false;
    		playermove.enabled = false;
    		PAUSEMENU.SetActive(true);
            Chat.SetActive(false);
   		 } else {
   		 	PAUSED = false;
    		Time.timeScale = 1;
    		blockbreak.enabled = true;
    		blockbuild.enabled = true;
    		itemdrop.enabled = true;
    		chatscript.enabled = true;
    		openthings.enabled = true;
    		hgb.enabled = true;
    		debug.enabled = true;
    		playermove.enabled = true;
    		PAUSEMENU.SetActive(false);
   		 }
    }
}
