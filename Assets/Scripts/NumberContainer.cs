using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NumberContainer : MonoBehaviour, INumContainer {

    public List<GameObject> numList;

    public static GameObject firstSelected;
    public static GameObject secondSelected;

	// Use this for initialization
	void Start () {
        numList = new List<GameObject>();
        firstSelected = null;
        secondSelected = null;
	}

    public void Add(GameObject obj) {
        numList.Add(obj);
    }

    public void Remove(GameObject obj) {
        numList.Remove(obj);
    }

    public int Size() {
        return numList.Count;
    }

    void Update() {
        if(firstSelected != null && secondSelected != null) {
            print("Selected");
            firstSelected = null;
            secondSelected = null;
        }
    }
}
