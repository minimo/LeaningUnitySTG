using UnityEngine;
using System.Collections;

public class Emitter : MonoBehaviour {

	//wave prefab
	public GameObject[] waves;
	private int currentWave;

	// Use this for initialization
	IEnumerator Start () {
 		if (waves.Length == 0) {
			yield break;
		}

		while (true) {
			//Create Wave
			GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity);

			//Wave add to Emitter
			wave.transform.parent = transform;

			//waint when delete wave all chidren.
			while(wave.transform.childCount != 0) {
				yield return new WaitForEndOfFrame();
			}

			Destroy(wave);

			if(waves.Length <= ++currentWave) {
				currentWave = 0;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
