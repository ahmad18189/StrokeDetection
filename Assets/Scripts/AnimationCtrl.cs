using UnityEngine;
using System.Collections;

public class AnimationCtrl : MonoBehaviour {
	public GameObject PS;
	public GameObject rock;
	void Awake(){
		Debug.Log ("Awake" );
		rock.SetActive (false);
		PS.SetActive (false);
	
	}
	public void AnimationEnded () {
		Debug.Log ("PEntered" );
		rock.SetActive (true);
		PS.SetActive (true);
	}
}
