using UnityEngine;
using System.Collections;

public class PlayerModel : MonoBehaviour {

	private Player owner;			// Pointer to the parent object.
	public Material mat;		// Material for setting/changing texture and color.
	private int fdirection;

	public void init(Player owner) {
		this.owner = owner;

		transform.parent = owner.transform;					// Set the model's parent to the gem.
		transform.localPosition = new Vector3(0,0,0);		// Center the model on the parent.
		name = "Player Model";									// Name the object.

		mat = GetComponent<Renderer>().material;		
		mat.shader = Shader.Find ("Sprites/Default");						// Tell the renderer that our textures have transparency. // Get the material component of this quad object.
		mat.mainTexture = Resources.Load<Texture2D>("Textures/Triangle");	// Set the texture.  Must be in Resources folder.
		mat.color = new Color(1,1,1);
	}

	void Update(){
		fdirection = owner.direction;
		transform.eulerAngles = new Vector3 (0, 0, 90* fdirection);
	}
}
