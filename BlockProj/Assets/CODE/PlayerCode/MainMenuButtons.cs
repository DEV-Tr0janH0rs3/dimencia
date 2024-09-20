using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public GameObject Create;
    public GameObject ChangeLog;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ClickCreateCreativeWorld()
    {
        SceneManager.LoadScene("CreativeGame");
    }
    public void ClickCreateSurvivalWorld()
    {
        SceneManager.LoadScene("SurvivalGame");
    }
    public void ClickCreateServer()
    {
        SceneManager.LoadScene("MP_Test");
    }
    public void ClickCreateWorld1()
    {
        Create.SetActive(true);
    }
    public void ClickChangeLog(){
        ChangeLog.SetActive(true);
    }
    public void CloseChangeLog(){
        ChangeLog.SetActive(false);
    }
    public void Back()
    {
        Create.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
