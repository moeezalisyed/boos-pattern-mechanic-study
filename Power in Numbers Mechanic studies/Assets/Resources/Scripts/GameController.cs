using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Player player;


	// Use this for initialization
	void Start () {

		GameObject playerObject = new GameObject();
		player = playerObject.AddComponent<Player>();
		player.transform.localPosition = new Vector3 (5, 0, 0);

		GameObject bossObject = new GameObject();
		Boss boss = bossObject.AddComponent<Boss>();
		boss.init (this);
	
	}
}
