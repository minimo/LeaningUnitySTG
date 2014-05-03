using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	Spaceship spaceship;
	// Use this for initialization
	IEnumerator Start () {
		spaceship = GetComponent<Spaceship> ();
		spaceship.move (transform.up * -1);

		if (!spaceship.canShot) {
			yield break;
		}

		while (true) {
			for (var i = 0; i < transform.childCount; i++) {
				Transform shotPosition = transform.GetChild(i);
				spaceship.shot (shotPosition);
			}
			yield return new WaitForSeconds(spaceship.shotDelay);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
