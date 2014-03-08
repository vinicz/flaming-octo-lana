using UnityEngine;
using System.Collections;

public class MouseSelect : MonoBehaviour {

	void OnMouseDown() {
        if(NumberContainer.firstSelected == null) {
            NumberContainer.firstSelected = gameObject;
            ToggleSelect(gameObject);
        } else if(NumberContainer.secondSelected == null) {
            NumberContainer.secondSelected = gameObject;
            Check();
        }
    }

    void ToggleSelect(GameObject obj) {
        Behaviour h = (Behaviour)obj.GetComponent("Halo");
        h.enabled = !h.enabled; 
    }

    void Check() {
        if(Random.Range(0f,1f) > 0.5f) {
            ToggleSelect(NumberContainer.firstSelected.gameObject);
        } else {
            Destroy(NumberContainer.firstSelected.gameObject);
            Destroy(gameObject);
        }
    }
}
