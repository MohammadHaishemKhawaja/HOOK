using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereCube : MonoBehaviour
{

	public GameObject[] Cube;

	public Transform[] spawnPoints;
	public int randomCube;
	public int randomSpawn;

    // Start is called before the first frame update
    void Start()
    {
		randomCube = Random.Range(1, 4);

		randomSpawn = Random.Range(1, 4);
		Instantiate(Cube[(randomCube)], spawnPoints[(randomSpawn)].position, transform.rotation);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
