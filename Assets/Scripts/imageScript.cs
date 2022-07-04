using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class imageScript : MonoBehaviour
{
	public coinScript coinScript1;
	public int menuOn;
	public coinScript pauseUI;

    // Start is called before the first frame update
    void Start()
    {


	}

	void Update(){

	
	}


	public void pauseGame(AnimationEvent evt) {



		Time.timeScale = 0;
		pauseUI.pauseGameUI.SetActive(true);
		pauseUI.startGameUI.SetActive(false);
	}

}