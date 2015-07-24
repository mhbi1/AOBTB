using UnityEngine;
using System.Collections;

public class EndlessModeButton : MonoBehaviour {
	
	public void StartEndless(string name) {
		Application.LoadLevel(name);
	}
}
