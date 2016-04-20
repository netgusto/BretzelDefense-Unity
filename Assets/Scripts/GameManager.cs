using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;

	public BoardManager boardScript;

	private int level = 3; 

	// Use this for initialization
	void Awake () {

		if (instance == null) {
			instance = this;
		} else if(instance != this) {
			Destroy (this.gameObject);
		}

		DontDestroyOnLoad (this.gameObject);

		boardScript = GetComponent<BoardManager> ();
		initGame ();
	}

	void initGame() {
		boardScript.SetupScene (level);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
