using UnityEngine;
using System.Collections;

public class oDot_Behavior : MonoBehaviour {

	public GameObject oDot;
	Color dotColor;
	float rColor;
	float gColor;
	float bColor;
	bool hasColor = false;
	
	public Color getColor (){
		if (hasColor == false) {
			hasColor = true;
			return getRandColor ();
		}
		else 
			return dotColor;
	}
	Color getRandColor() {
		rColor = Random.Range (0.0f, 1.0f);
		gColor = Random.Range (0.0f, 1.0f);
		bColor = Random.Range (0.0f, 1.0f);
		dotColor = new Color(rColor, gColor ,bColor,1);
		return dotColor;
	}

}
