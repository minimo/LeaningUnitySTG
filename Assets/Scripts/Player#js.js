#pragma strict

var speed = 5;

function Start () {

}

function Update () {
	var x = Input.GetAxisRaw("Horizontal");
	var y = Input.GetAxisRaw("Vertical");
	
	var direction = Vector2(x,y).normalized;
	rigidbody2D.velocity = direction * speed;
}