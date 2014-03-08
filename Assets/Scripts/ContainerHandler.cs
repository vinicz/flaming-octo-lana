using UnityEngine;
using System.Collections;

public class ContainerHandler : MonoBehaviour {

    public NumberContainer container;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag.Equals("Number")) {
            container.Add(other.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other) {
        if(other.tag.Equals("Number")) {
            container.Remove(other.gameObject);
        }
    }
}
