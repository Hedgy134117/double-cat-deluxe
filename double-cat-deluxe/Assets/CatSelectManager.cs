using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSelectManager : MonoBehaviour
{
    public List<Cat> cats;
    CatScriptableObject currentCat;
    [SerializeField] GameObject controlSchemeSelectField;

    void Start() {
        DontDestroyOnLoad(gameObject);    
    }

    public void selectCatSO(CatScriptableObject cat) {
        currentCat = cat;
        controlSchemeSelectField.SetActive(true);
    }

    public void selectControlScheme(ControlScheme controlScheme) {
        cats.Add(new Cat(currentCat, controlScheme));
        controlSchemeSelectField.SetActive(false);
    }
}
