using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TDTS2 : MonoBehaviour
{

	public TMP_Text playername;
	public Scene logon;

    // Start is called before the first frame update
    void Awake()
    {
        playername.text = TDTS.player_name;
    }
}
