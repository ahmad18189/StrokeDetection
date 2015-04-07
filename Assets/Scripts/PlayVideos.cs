using UnityEngine;
using System.Collections;

public class PlayVideos : MonoBehaviour {

	public void StartVideo () {
		Handheld.PlayFullScreenMovie ("What Is A Stroke.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
}
