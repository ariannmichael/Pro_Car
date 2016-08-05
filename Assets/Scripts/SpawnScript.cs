using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] chao;
	[SerializeField] public float spawnMin = 1f;
	[SerializeField] public float spawnMax = 2f;


	// Use this for initialization
	void Start () {
		Spawn ();
	
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate (chao [Random.Range (0, chao.GetLength (0))], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range(spawnMin,spawnMax));
	
	}
}
