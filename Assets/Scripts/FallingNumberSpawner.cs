using UnityEngine;
using System.Collections;

public class FallingNumberSpawner : MonoBehaviour {

	public GameObject numberAssemblerObject;

	public float spawnWidth = 5;
	public int numMin = 1;
	public int numMax = 50;
	public float spawnMin = 0.5f;
	public float spawnMax = 2f;

	public float gravScaleMin = 0.1f;
	public float gravScaleMax = 0.3f;

	public float massMin = 0.1f;
	public float massMax = 0.5f;

	// Use this for initialization
	void Start () {
		Spawn ();
	}

	void Spawn () {
		int num = Random.Range(numMin, numMax);

		Vector3 pos = transform.position;
		pos.x += Random.Range(-1f, 1f) * (spawnWidth / 2f);

		GameObject newNumber = (GameObject)Instantiate (numberAssemblerObject, pos, Quaternion.identity);

		NumberAssembler numberAssembler = newNumber.GetComponent<NumberAssembler> ();
		numberAssembler.Number = num;
		numberAssembler.tag = "Number";

		Rigidbody2D rbody = numberAssembler.GetComponent<Rigidbody2D>();
		rbody.gravityScale = Random.Range(gravScaleMin, gravScaleMax);
		rbody.mass = Random.Range(massMin, massMax);

		Invoke ("Spawn", Random.Range(spawnMin, spawnMax));
	}
}
