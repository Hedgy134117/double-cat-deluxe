using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Cats")]
    [SerializeField] List<CatScriptableObject> catScriptableObjects;
    [SerializeField] List<Cat> cats;
    [SerializeField] List<GameObject> catGameObjects;
    [SerializeField] GameObject catPrefab;
    [Header("Game")]
    [SerializeField] BoxCollider2D spawningArea;

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
            catGameObjects.Add(catGameObject);
        }
        Camera.main.GetComponent<MultipleTargetCamera>().findCats();
        startRound();
    }

    public void startRound() {
        Bounds spawningAreaBounds = spawningArea.bounds;
        foreach (GameObject cat in catGameObjects)
        {
            Vector2 spawnPos = new Vector2(
                Random.Range(spawningAreaBounds.min.x, spawningAreaBounds.max.x),
                Random.Range(spawningAreaBounds.min.y, spawningAreaBounds.max.x)
            );
            cat.transform.position = spawnPos;
        }
    }

    public void endRound(GameObject losingCat) {
        Cat winner = null;
        for (int i = 0; i < catGameObjects.Count; i++) {
            if (catGameObjects[i] == losingCat) {
                winner = cats[i];
            }
        }
        startRound();
    }
}
