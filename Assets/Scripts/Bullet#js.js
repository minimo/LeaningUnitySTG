#pragma strict

var speed = 10;

function Start () {
	rigidbody2D.velocity = transform.up.normalized*speed;
}

function Update () {

}