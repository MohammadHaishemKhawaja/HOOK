using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawn : MonoBehaviour
{
	public GameObject[] Coin;
	public int randomCoin;
	public int randomSpawn;
	public Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
		randomCoin = Random.Range(1, 9);
		randomCoin = Random.Range(1, 3);
	
		Instantiate(Coin[(randomCoin)], spawnPoints[(randomSpawn)].position, transform.rotation = Quaternion.Euler(120,40,94));
		print(randomSpawn);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
