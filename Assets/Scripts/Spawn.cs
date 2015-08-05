using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject oDot;
	public GameObject backGround;
	Color dotColor;
	float canvasWidth;
	float canvasHeight;
	Vector3 dotSpawnLocation;

	void Start () {
		canvasWidth = backGround.GetComponent<Renderer> ().bounds.extents.x;
		canvasHeight = backGround.GetComponent<Renderer> ().bounds.extents.y;
		spawnDots ();
	}
	
	IEnumerator spawnDots () {
		yield return new WaitForSeconds(2.0f);
		//dotColor = oDot.GetComponent<oDot_Behavior>.getColor();
		dotSpawnLocation = new Vector3(getRandX(), getRandY(),0);
		Quaternion rot = Quaternion.identity;
		Instantiate (oDot, dotSpawnLocation, rot);
	}

	float getRandX () {
		float xPos = Random.Range (0.0f, canvasWidth);
		return xPos;
	}

	float getRandY () {
		float yPos = Random.Range (0.0f, canvasHeight);
		return yPos;
	}
}