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
    [SerializeField] UIManager uiManager;

    void Awake() {
        GameObject catSelectManager = GameObject.FindGameObjectWithTag("CatSelectManager");
        if (catSelectManager != null) {
            cats = catSelectManager.GetComponent<CatSelectManager>().cats;
        }
        else {
            for (int i = 0; i < catScriptableObjects.Count; i++) {
                cats.Add(new Cat(catScriptableObjects[i], (ControlScheme) i));
            }
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
            cat.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            cat.GetComponent<Rigidbody2D>().angularVelocity = 0f;
            cat.transform.rotation = Quaternion.identity;
        }
    }

    public void endRound(GameObject losingCat) {
        Cat loser = null;
        for (int i = 0; i < catGameObjects.Count; i++) {
            if (catGameObjects[i] == losingCat) {
                loser = cats[i];
            }
        }
        foreach (Cat cat in cats)
        {
            if (cat != loser) {
                cat.points += 1;
            }
        }
        uiManager.displayScore(cats);
        startRound();
    }
}
