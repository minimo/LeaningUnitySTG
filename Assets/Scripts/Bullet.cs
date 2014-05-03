using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public int speed = 10;
	public int lifeTime = 5;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up.normalized*speed;
		Destroy (gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
