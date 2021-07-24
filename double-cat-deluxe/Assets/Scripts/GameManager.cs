using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<CatScriptableObject> catScriptableObjects;
    [SerializeField] List<Cat> cats;
    [SerializeField] GameObject catPrefab;

    void Awake() {
        for (int i = 0; i < catScriptableObjects.Count; i++) {
            cats.Add(new Cat(catScriptableObjects[i], (ControlScheme) i));
        }
    }

    void OnEnable() {
        foreach (Cat cat in cats)
        {
            GameObject catGameObject = Instantiate(catPrefab);
            catGameObject.GetComponent<CatSetter>().cat = cat;
        }
        Camera.main.GetComponent<MultipleTargetCamera>().findCats();
    }
}
