using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float jumpForce = 10f;

	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public string currentColor;
	public Color colorCyan;
	public Color colorYellow;
	public Color colorMagenta;
	public Color colorPink;

	void Start () {
		SetRandomColor();
	}

	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0)) {
			rb.velocity = Vector2.up * jumpForce;
		}
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Color Changer") {
			SetRandomColor();
			Destroy(col.gameObject);
			return;
		}

		if (col.tag != currentColor) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

	void SetRandomColor () {
		int index = Random.Range(0, 4);

		switch (index) {
			case 0:
					currentColor = "Cyan";
					sr.color = colorCyan;
					break;
			case 1:
					currentColor = "Yellow";
					sr.color = colorYellow;
					break;
			case 2:
					currentColor = "Magenta";
					sr.color = colorMagenta;
					break;
			case 3:
					currentColor = "Pink";
					sr.color = colorPink;
					break;
		}
	}
}
