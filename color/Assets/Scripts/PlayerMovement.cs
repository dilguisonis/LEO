using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<PlayerController> ().isplaying = true;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void Move(float currentx)
	{
		if (this.gameObject.GetComponent<PlayerController> ().isplaying) {
			
		
		//transform.transform.position = new Vector2 (50, transform.position.y);
		//transform.position = new Vector2(currentx, transform.position.y);
		transform.position=Vector2.Lerp (transform.position, new Vector2(currentx, transform.position.y), 5f);
		//transform.position=Mathf.Lerp(transform.position, new Vector2(currentx, transform.position.y), Mathf.SmoothStep(0.0, 1.0, 5f));
		}
		}
}
