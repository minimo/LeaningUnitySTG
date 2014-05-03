#pragma strict

var speed = 5;
var bullet : GameObject;

function Start () {
}

function Update () {
	var x = Input.GetAxisRaw("Horizontal");
	var y = Input.GetAxisRaw("Vertical");
	
	var direction = Vector2(x,y).normalized;
	rigidbody2D.velocity = direction * speed;

	Instantiate(bullet, transform.position, Quaternion.identity);
}
