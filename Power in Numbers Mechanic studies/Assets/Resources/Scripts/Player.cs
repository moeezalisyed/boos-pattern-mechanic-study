using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private PlayerModel model;
	private float speed;
	public int direction;


	// Use this for initialization
	void Start () {
		this.name = "Player";
		speed = 3;
		direction = 0;

		var modelObject = GameObject.CreatePrimitive(PrimitiveType.Quad);	// Create a quad object for holding the gem texture.
		model = modelObject.AddComponent<PlayerModel>();						// Add a marbleModel script to control visuals of the gem.
		model.init(this);

		BoxCollider2D playerbody = gameObject.AddComponent<BoxCollider2D> ();
		Rigidbody2D playerRbody = gameObject.AddComponent<Rigidbody2D> ();
		playerRbody.gravityScale = 0;
		playerbody.isTrigger = true;
		transform.localScale = new Vector3 (.5f, .5f, 1);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
			direction =1;
			if (transform.position.x > -6) {
				transform.Translate (Vector3.left * Time.deltaTime * speed);
			}
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			direction = 3;
			if (transform.position.x < 6) {
				transform.Translate (Vector3.right * Time.deltaTime * speed);
			}
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			direction = 0;
			if (transform.position.y < 4.8) {
				transform.Translate (Vector3.up * Time.deltaTime * speed);
			}
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			direction = 2;
			if (transform.position.y > -4.8) {
				transform.Translate (Vector3.down * Time.deltaTime * speed);
			}
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Boss") {
			Destroy (this.gameObject);
		}
		if (other.name == "BossBullet") {
			Destroy (this.gameObject);
		}
		if (other.name == "BossBeam") {
			Destroy (this.gameObject);
		}
	}

}
