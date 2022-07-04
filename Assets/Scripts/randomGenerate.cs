using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomGenerate : MonoBehaviour
{
	public GameObject[] Cube;

	public Transform[] spawnPoints;
	public int randomCube;
	public int randomSpawn;

	// Start is called before the first frame update
    void Start()
    {
		
		randomCube = Random.Range(1, 3);
		print(randomCube);
		randomSpawn = Random.Range(1, 3);
		Instantiate(Cube[(randomCube)], spawnPoints[(randomSpawn)].position, transform.rotation );
		print(randomCube);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
