using UnityEngine;
using System.Collections;

public interface INumContainer {
    void Add(GameObject obj);
    void Remove(GameObject obj);
    int Size();
}
