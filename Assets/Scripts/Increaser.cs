using UnityEngine;
using System.Collections;

public class Increaser : MonoBehaviour {

	public GameObject preFab;
	private float numberCount =1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			
			if(collider2D.OverlapPoint(mousePosition))
			{
				GameObject obj = (GameObject) Instantiate(preFab);

				obj.transform.parent = transform;
				obj.transform.localPosition = new Vector3(numberCount*0.5f,0.0f,0.0f);
				//obj.transform.position = transform.position;
				obj.transform.rotation = transform.rotation;
				//obj.transform.Translate(new Vector3(numberCount*0.5f,0.0f,0.0f));

				((BoxCollider2D)collider2D).size = new Vector2(((BoxCollider2D)collider2D).size.x+ 0.4f, ((BoxCollider2D)collider2D).size.y);
				((BoxCollider2D)collider2D).center = new Vector2(((BoxCollider2D)collider2D).center.x+ 0.4f, ((BoxCollider2D)collider2D).center.y);

				//collider2D.transform.localScale = new Vector2(collider2D.transform.localScale.x+0.5f, collider2D.transform.localScale.y);
				numberCount++;
			}
			
			
		}

		rigidbody2D.AddForce (Input.acceleration * 100);

	}

}
