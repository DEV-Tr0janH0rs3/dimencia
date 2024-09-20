using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatScript : MonoBehaviour
{
    public GameObject chat;
    public GameObject theGenerator;
    public GameObject ILN;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) { 
        
            if (!chat.activeSelf)
            {
                this.gameObject.GetComponent<PlayerMovement>().enabled = false;
                this.gameObject.GetComponent<BlockBuildS>().enabled = false;
                this.gameObject.GetComponent<BlockBreakS>().enabled = false;
                this.gameObject.GetComponent<HighlightBlock>().enabled = false;
                chat.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            this.gameObject.GetComponent<PlayerMovement>().enabled = true;
            this.gameObject.GetComponent<BlockBuildS>().enabled = true;
            this.gameObject.GetComponent<BlockBreakS>().enabled = true;
            this.gameObject.GetComponent<HighlightBlock>().enabled = true;
            chat.SetActive(false);
            if(chat.GetComponent<InputField>().text == ".kill items"){
                GameObject[] items;
                items = GameObject.FindGameObjectsWithTag("Item");
                foreach (GameObject item in items)
                {
                    Destroy(item);
                }
            }
            if (chat.GetComponent<InputField>().text == ".iln")
            {
                 ILN.SetActive(true);
        
            }
            if(chat.GetComponent<InputField>().text.Contains(".drop:")){
                string chatText = chat.GetComponent<InputField>().text;
                string toBeSearched = ".drop:";
                string after = chatText.Substring(chatText.IndexOf(toBeSearched) + toBeSearched.Length);
                if(after != ""){
                    after = after.ToLower();
                    if(theGenerator.GetComponent<Items>().itemite.Contains(after)){
                        theGenerator.GetComponent<Items>().DropItem(after);   
                    }
                }
            }
            if(chat.GetComponent<InputField>().text.Contains(".time:")){
                string chatText = chat.GetComponent<InputField>().text;
                string toBeSearched = ".time:";
                string after = chatText.Substring(chatText.IndexOf(toBeSearched) + toBeSearched.Length);
                Debug.Log(after);
                if(after != ""){
                    after = after.ToLower();
                    try{
                    	int time = int.Parse(after);
                    	theGenerator.GetComponent<TimeScript>().GameTime = (float)time; 
                    	
                    } catch (System.FormatException e) {
                    	if(after == "day"){
                        	theGenerator.GetComponent<TimeScript>().GameTime = 1199f;   
                    	}
                    	if(after == "night"){
                        	theGenerator.GetComponent<TimeScript>().GameTime = 599f;   
                    	}
                    }
                }
            }
            chat.GetComponent<InputField>().text = "";
        }
    }

    public void CloseILN()
    {
        ILN.SetActive(false);
    }

}
