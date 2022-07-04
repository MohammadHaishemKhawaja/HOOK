using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map1 : MonoBehaviour
{
	public GameObject[] introRamps;
	public GameObject[] startRamps;
	public GameObject[] middleRamps;
	public GameObject[] endRamps;


	public GameObject introRamps1;
	public GameObject startRamps1;
	public GameObject middleRamps1;
	public GameObject endRamps1;
	public GameObject introRamps2;
	public GameObject startRamps2;
	public GameObject middleRamps2;
	public GameObject endRamps2;


	public int randomIntroRamp;
	public int randomStartRamp;
	public int randomMiddleRamp;
	public int randomEndRamp;

    // Start is called before the first frame update
    void Start()
    {
		randomIntroRamp = Random.Range(0, 9);
		introRamps[(randomIntroRamp)].SetActive(false);
	


		randomStartRamp = Random.Range(0, 9);
		startRamps[(randomStartRamp)].SetActive(false);
	

		randomMiddleRamp = Random.Range(0, 9);
		middleRamps[(randomMiddleRamp)].SetActive(false);
	

		randomEndRamp = Random.Range(0, 9);
		endRamps[(randomEndRamp)].SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void randomizeRamps (){
		introRamps1.SetActive(false);
		startRamps1.SetActive(false);
		middleRamps1.SetActive(false);
		endRamps1.SetActive(false);
		introRamps2.SetActive(false);
		startRamps2.SetActive(false);
		middleRamps2.SetActive(false);
		endRamps2.SetActive(false);


		randomIntroRamp = Random.Range(0, 9);
		randomStartRamp = Random.Range(0, 9);
		randomMiddleRamp = Random.Range(0, 9);
		randomEndRamp = Random.Range(0, 9);
		introRamps[(randomIntroRamp)].SetActive(true);
		startRamps[(randomStartRamp)].SetActive(true);
		middleRamps[(randomMiddleRamp)].SetActive(true);
		endRamps[(randomEndRamp)].SetActive(true);

	}
}
