using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theGenerator : MonoBehaviour {
	public GameObject[] buildings;
	public float mapWidth = 80;
	public float mapHeight = 80;
	float spacer = 10;
	// Use this for initialization
	void Start () {
		StartCoroutine(Generate());
		// float seed = Random.Range(0,100); // reads perlin noise at random points for new gens yo
		// for(float h = 0; h < mapWidth; h++) {
		// 	for(float w = 0; w < mapWidth; w++) {
                
        //         int perlinNoise = (int) (Mathf.PerlinNoise(w/10.0f + seed,h/10.0f + seed) * 10);
		// 		Vector3 pos = new Vector3(w * spacer,0,h * spacer);
		// 		// int n = Random.Range(0, buildings.Length);
		// 		// Instantiate(buildings[n], pos, Quaternion.identity);

		// 		if(perlinNoise < 2) {
		// 			Instantiate(buildings[0], pos, Quaternion.identity);
		// 		} else if (perlinNoise < 4) {
		// 			Instantiate(buildings[1], pos, Quaternion.identity);
		// 		} else if (perlinNoise < 6) {
		// 			Instantiate(buildings[2], pos, Quaternion.identity);
		// 		} else if (perlinNoise < 8) {
		// 			Instantiate(buildings[3], pos, Quaternion.identity);
		// 		} else if (perlinNoise < 10) {
		// 			Instantiate(buildings[4], pos, Quaternion.identity);
		// 		}
		// 		// yield return new WaitForSeconds(1);
		// 	}
		// }
		
	}


	 IEnumerator Generate() {
		float seed = Random.Range(0,100); // reads perlin noise at random points for new gens yo
		for(float h = 0; h < mapWidth; h++) {
			for(float w = 0; w < mapWidth; w++) {
                yield return new WaitForSeconds(1);
                int perlinNoise = (int) (Mathf.PerlinNoise(w/10.0f + seed,h/10.0f + seed) * 10);
				Vector3 pos = new Vector3(w * spacer,0,h * spacer);
				// int n = Random.Range(0, buildings.Length);
				// Instantiate(buildings[n], pos, Quaternion.identity);

				if(perlinNoise < 2) {
					Instantiate(buildings[0], pos, Quaternion.identity);
				} else if (perlinNoise < 4) {
					Instantiate(buildings[1], pos, Quaternion.identity);
				} else if (perlinNoise < 6) {
					Instantiate(buildings[2], pos, Quaternion.identity);
				} else if (perlinNoise < 8) {
					Instantiate(buildings[3], pos, Quaternion.identity);
				} else if (perlinNoise < 10) {
					Instantiate(buildings[4], pos, Quaternion.identity);
				}
				// yield return new WaitForSeconds(1);
			}
		}
	 }
	
	
	// // Update is called once per frame
	// void Update () {
		
	// }
}
