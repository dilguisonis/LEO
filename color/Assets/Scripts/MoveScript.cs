using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	public float speed;
	private TimeInGame TIM;
	// Use this for initialization
	void Start () {
		TIM = GameObject.FindObjectOfType<TimeInGame> ();
		speed = TIM.velocity;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position,new Vector2 (0f, -250f), Time.deltaTime * speed);

		if (transform.position == new Vector3 (0f, -250f, 0f)) {	
			GameObject.FindObjectOfType<SpawnScript> ().LineList.Remove (this.gameObject);
			Destroy (this.gameObject);
		}
	}
}
