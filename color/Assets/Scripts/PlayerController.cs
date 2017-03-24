using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Color Color;
	public string ColorString;
	public bool isplaying;

	public int colorint;

	public Color BlueColor = new Color (0f, 0.26f, 223f);
	public Color GreenColor = new Color (0f,255f,0f);
	public Color RedColor = new Color (255f,0f,0f);
	public Color YellowColor = new Color (255f,255f,0f);

	public bool PlayerIsBlue = false;
	public bool PlayerIsRed = false;
	public bool PlayerIsYellow = false;
	public bool PlayerIsGreen = false;

	void Start(){
		SetColorPlayer (Mathf.RoundToInt(Random.Range(1f,4f)));
	}

	public void SetColorPlayer(int color)
	{
		switch (color) {
		case 1:
			this.gameObject.GetComponentInChildren<SpriteRenderer> ().color = BlueColor;
			gameObject.tag = "Color Blue";
			ColorString = "Color Blue";
			PlayerBoolColor (1);
			colorint = 1;
			break;
		case 2:
			this.gameObject.GetComponentInChildren<SpriteRenderer> ().color = RedColor;
			gameObject.tag = "Color Red";
			ColorString = "Color Red";
			PlayerBoolColor (2);
			colorint = 2;
			break;
		case 3:
			this.gameObject.GetComponentInChildren<SpriteRenderer> ().color = YellowColor;
			gameObject.tag = "Color Yellow";
			ColorString = "Color Yellow";
			PlayerBoolColor (3);
			colorint = 3;
			break;
		case 4:
			this.gameObject.GetComponentInChildren<SpriteRenderer> ().color = GreenColor;
			gameObject.tag = "Color Green";
			ColorString = "Color Green";
			PlayerBoolColor (4);
			colorint = 4;
			break;
		}
	}
	void PlayerBoolColor(int color)
	{
		switch (color) {
		case 1:
			PlayerIsBlue = true;
			PlayerIsRed = false;
			PlayerIsYellow = false;
			PlayerIsGreen = false;
			break;
		case 2:
			PlayerIsBlue = false;
			PlayerIsRed = true;
			PlayerIsYellow = false;
			PlayerIsGreen = false;
			break;
		case 3:
			PlayerIsBlue = false;
			PlayerIsRed = false;
			PlayerIsYellow = true;
			PlayerIsGreen = false;
			break;
		case 4:
			PlayerIsBlue = false;
			PlayerIsRed = false;
			PlayerIsYellow = false;
			PlayerIsGreen = true;
			break;
		}
	}
}
