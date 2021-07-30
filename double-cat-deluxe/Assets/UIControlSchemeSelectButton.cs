using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControlSchemeSelectButton : MonoBehaviour
{
    [SerializeField] ControlScheme controlScheme;
    CatSelectManager catSelectManager;

    void Awake() {
        catSelectManager = GameObject.FindGameObjectWithTag("CatSelectManager").GetComponent<CatSelectManager>();    
    }

    public void selectControlScheme() {
        catSelectManager.selectControlScheme(controlScheme);
        Destroy(gameObject);
    }
}
