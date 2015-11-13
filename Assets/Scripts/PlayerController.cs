using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float xMove;
	public float zMove;
	public Vector3 moveDirection;
	public Rigidbody rigidBody;
	void Start () {
		if (rigidBody == null)
			rigidBody = GetComponent<Rigidbody> ();
	}

	void Update () {
		xMove = Input.GetAxis ("Horizontal");
		zMove = Input.GetAxis ("Vertical");

		moveDirection = new Vector3 (xMove, 0, zMove);
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection *= speed;
		rigidBody.MoveRotation (transform.rotation);
		rigidBody.MovePosition (transform.position + (moveDirection * Time.deltaTime));
	}
}
