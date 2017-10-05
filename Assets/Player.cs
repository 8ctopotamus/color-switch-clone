using UnityEngine;

public class Player : MonoBehaviour {

	public float jumpForce = 10f;

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) {
			rb.velocity = Vector2.up * jumpForce;
		}
	}
}
