using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour {

	public void OnClick(){
		if(Input.GetButtonDown("Play")){
			print ("start");
			SceneManager.LoadScene ("level1");
		}
	}
}
