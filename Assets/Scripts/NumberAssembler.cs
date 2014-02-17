using UnityEngine;
using System.Collections;

public class NumberAssembler : MonoBehaviour
{


		private float _number;
		public GameObject number0;
		public GameObject number1;
		public GameObject number2;
		public GameObject number3;
		public GameObject number4;
		public GameObject number5;
		public GameObject number6;
		public GameObject number7;
		public GameObject number8;
		public GameObject number9;

		public float Number {
				get{ return _number;}
				set {
						_number = value;

						int digitCount = 0;
						float currentValue = (float)value;
					
						while (currentValue>=1.0f) {
								currentValue /= 10.0f;
								digitCount++;
						}
						if (digitCount == 0) {
								digitCount = 1;

						}
						

						Debug.Log ("Number " + value);
						Debug.Log ("DigitCount " + digitCount);

						int colorId = (int)Random.Range (0, 5);
						Color color = Color.white;

						switch (colorId) {
						case 0:
								color = Color.blue;
								break;
						case 1:
								color = Color.cyan;
								break;
						case 2:
								color = Color.gray;
								break;
						case 3:
								color = Color.green;
								break;
						case 4:
								color = Color.magenta;
								break;
						case 5:
								color = Color.white;
								break;

						}
						
						int numberCount = 0;
						float currentNumberValue = value;
						while (digitCount-->0) {
								float multiplier = Mathf.Pow (10, digitCount);
								int currentDigitValue = (int)(currentNumberValue / multiplier);
								currentNumberValue -= currentDigitValue * multiplier;

								Debug.Log ("currentDigitValue " + currentDigitValue);

								GameObject preFab = null;

								switch (currentDigitValue) {
								case 0:
										preFab = number0;
										break;
								case 1:
										preFab = number1;
										break;
								case 2:
										preFab = number2;
										break;
								case 3:
										preFab = number3;
										break;
								case 4:
										preFab = number4;
										break;
								case 5:
										preFab = number5;
										break;
								case 6:
										preFab = number6;
										break;
								case 7:
										preFab = number7;
										break;
								case 8:
										preFab = number8;
										break;
								case 9:
										preFab = number9;
										break;
								default:	
										preFab = number0;
										break;
								}


								GameObject obj = (GameObject)Instantiate (preFab);
				
								obj.transform.parent = transform;
								obj.transform.localPosition = new Vector3 (numberCount * 0.5f, 0.0f, 0.0f);

								obj.transform.rotation = transform.rotation;
								
								obj.renderer.material.color = color;
				
								((BoxCollider2D)collider2D).size = new Vector2 (((BoxCollider2D)collider2D).size.x + 0.4f, ((BoxCollider2D)collider2D).size.y);
								((BoxCollider2D)collider2D).center = new Vector2 (((BoxCollider2D)collider2D).center.x + 0.4f, ((BoxCollider2D)collider2D).center.y);

								numberCount++;
						}

				}
		}

	

		// Update is called once per frame
		void Update ()
		{
				rigidbody2D.AddForce (Input.acceleration * 100);
	
		}
}
