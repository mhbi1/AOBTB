using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class StartButton : MonoBehaviour {

	public void StartGame(int index){
		Application.LoadLevel(index);
	}

	public void StartGame(string name){
		Application.LoadLevel(name);
	}
}