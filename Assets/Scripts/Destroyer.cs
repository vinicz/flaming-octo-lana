using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag.Equals("Number")) {
			Destroy (other.gameObject);
		}
	}
}
