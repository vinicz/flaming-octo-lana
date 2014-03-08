using UnityEngine;
using System.Collections;

public class NumberSpawner : MonoBehaviour {

    public GameObject numberAssemblerObject;
        
    // Use this for initialization
    void Start() {
        for (int i =0; i<125; i++) {
                
            GameObject newNumber = (GameObject)Instantiate(numberAssemblerObject);
                
            NumberAssembler numberAssembler = newNumber.GetComponent<NumberAssembler>();
            numberAssembler.Number = i;

            int layerId = (int)Random.Range(8, 18);

            newNumber.layer = layerId;
        }
    }
    
    // Update is called once per frame
    void Update() {
                    
    }
}
