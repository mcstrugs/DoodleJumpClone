using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;
	public GameObject superPlatformPrefab;

    public int numberOfPlatforms;
	public float superPlatRarity;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    
    // Use this for initialization
	void Start ()
    {
		Vector3 spawnPosition = new Vector3();
		spawnPosition.y -= 3f;
		float currentThing = 0f;
		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += Random.Range(minY, maxY);
			//spawnPosition.y += 0.2f;
			//spawnPosition.x = levelWidth*Mathf.Sin(currentThing) + Mathf.Cos(2*currentThing);
			spawnPosition.x = Random.Range(-levelWidth,levelWidth);
			if(Random.Range(0f, 1f) < superPlatRarity)
			{
				Instantiate(superPlatformPrefab, spawnPosition, Quaternion.identity);
			}
			else
			{
				Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
			}
			//currentThing += 0.2f;
		}
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
