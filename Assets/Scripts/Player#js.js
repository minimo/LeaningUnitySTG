#pragma strict

var speed = 5;

GameObject bullet;

function Start () {
	yield entershot();
}

function Update () {
	var x = Input.GetAxisRaw("Horizontal");
	var y = Input.GetAxisRaw("Vertical");
	
	var direction = Vector2(x,y).normalized;
	rigidbody2D.velocity = direction * speed;
}

function enterShot() {
	Instantiate(bullet, transform.position, transform.rotation);
	yield WaitForSeconds (0.05f);
}
