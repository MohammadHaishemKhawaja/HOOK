using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinScript : MonoBehaviour
{
	public Text CoinText;
	public int coins = 0;
	public bool ifHit = false;
	public bool spawnImageThing = false;
	public GameObject canvas;
	public GameObject Player;
	public bool ifHit1 = false;
	public GameObject pauseGameUI;
	public GameObject startGameUI;
	public GameObject scoreUI;
	public Text bestScoreText;


    void Start()
    {

		Time.timeScale = 0f;
		scoreUI.SetActive(false);
		startGameUI.SetActive(true);
		pauseGameUI.SetActive(false);





    }

    // Update is called once per frame
    void Update()
    {
		CoinText.text = "" + coins;
		if(coins> PlayerPrefs.GetInt("highestscore")){
		PlayerPrefs.SetInt("highestscore", coins);
		}
		if (ifHit == false) {

			Player.GetComponent<Image>().enabled = true;
			Player.GetComponent<Animator>().enabled = true;


		}
		if (ifHit == true) {

			Player.GetComponent<Image>().enabled = false;
			Player.GetComponent<Animator>().enabled = false;


		}

		if (Input.GetMouseButtonDown(0)) {
			Time.timeScale = 1f;
			startGameUI.SetActive(false);
			scoreUI.SetActive(true);
		}
	}




    void OnTriggerEnter(Collider col){
		
		if (col.gameObject.CompareTag ("Ruby")) {
			coins = coins + 1;
			col.gameObject.SetActive(false);
			ifHit = true;

			Invoke("setIt", 0.1f);


		}
	}

		



	void setIt(){
		ifHit = false;

		Player.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animation/Image1") as RuntimeAnimatorController;
		if (Player.GetComponent<Animator>().runtimeAnimatorController == Resources.Load("Animation/Image1") as RuntimeAnimatorController) {
			Player.GetComponent<Animator>().runtimeAnimatorController = Resources.Load("Animation/Image") as RuntimeAnimatorController;
	}



	}

}
