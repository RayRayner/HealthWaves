using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour {

    public int waveHealth;
    public GameObject[] objs;
    public Vector3 spawnLocation;

    // Use this for initialization
    void Start () {
        StartCoroutine("spawnPeople");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator spawnPeople () {
        int spawned = Mathf.FloorToInt(Random.Range(1, 5));
        Instantiate(objs[spawned-1], spawnLocation, Quaternion.identity);
        yield return new WaitForSeconds(0.1f);
        waveHealth -= spawned;
        spawnLocation += (Vector3.forward*2);
        if (waveHealth > 0) {
			StartCoroutine("spawnPeople");
		}

    }
}
