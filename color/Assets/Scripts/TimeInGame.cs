using UnityEngine;
using System.Collections;

public class TimeInGame : MonoBehaviour {
	bool candothisshitornot = false;
	public float velocity;
	public float time;
	public float bonustime;
	bool lose;
	bool stop;
	public float spawntime;
	// Use this for initialization
	void Start () {
		spawntime = 0.8f;
		bool stop = false;
		velocity = 100f;
		time = 0;
		bonustime = 0;
		lose = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (lose) {
		if (time > 5f) {
			stop = true;
				lose = false;
		}

		}
		if (stop) {
			velocity += Time.deltaTime * 5f;
			if (velocity >= 250f) {
				stop = false;
			}
		}

		time = time + Time.deltaTime;
		bonustime = bonustime + Time.deltaTime;
	}
}
