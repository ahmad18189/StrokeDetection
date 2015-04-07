using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeMatColor : MonoBehaviour {
public void SetMatirialColor(GameObject go ) {
		go.GetComponent<Image>().color = Color.blue;
	}
}
