using UnityEngine;
using System.Collections;

public class ChangeScenes : MonoBehaviour {

	public void GoToScene(string scene){
		Application.LoadLevel(scene);
	}
	public void ClickTest (string a)
	{
		Debug.Log ( a);
	}
}
