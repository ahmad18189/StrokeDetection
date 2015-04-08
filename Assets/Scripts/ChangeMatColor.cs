using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeMatColor : MonoBehaviour {
	public GameObject [] MyButtons ;


	public void SetMatirialColorRed(GameObject go) {
		go.GetComponent<Image> ().color = Color.red;
	}
	public void SetMatirialColorBlue(GameObject go) {
		foreach (GameObject asd in MyButtons)
			SetMatirialColorRed(asd);
		go.GetComponent<Image> ().color = Color.blue;
	}
}
