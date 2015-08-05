#pragma strict
import System.Collections; 
import UnityEngine.UI;
import UnityEngine;  

	var colorStart : Color= Color.white;
	var colorEnd : Color;
	var colorRandomizer: Color;
	var duration : float = 1.0;
	var rend: Renderer;
	var simpleVersion: int;//if 0 then game is harder, if 1 then game only does simple colors
	 
 
 
 var imgObj : GameObject;  //drag your Canvas here
 var img : Image ; //drag your image here
	
function Start () {
	simpleVersion=0;
	//colorEnd=RandomColor();
	colorEnd=new Color(1,0,1,1);
	//rend = GetComponent.<Renderer>();
	//rend.material.color=colorEnd;
	
}

function Update(){
	img.color =colorEnd;
}

function RandomColor() {
	// A different random value is used for each color component (if
	// the same is used for R, G and B, a shade of grey is produced).
	if(simpleVersion==0){
	return new Color(Random.value, Random.value, Random.value);}
	else if(simpleVersion==1){ 
		var randomNum=Random.Range(0,6);
		switch(randomNum){
		case 0: return new Color(0,0,1,1);
			break;
		case 1: return new Color(0,1,0,1);
			break;
		case 2: return new Color(0,1,1,1);
			break;
		case 3: return new Color(1,0,0,1);
			break;
		case 4: return new Color(1,0,1,1);
			break;
		case 5: return new Color(1,1,0,1);
			break;
		case 6: return new Color(1,1,1,1);
			break;
		}
		
	}
}