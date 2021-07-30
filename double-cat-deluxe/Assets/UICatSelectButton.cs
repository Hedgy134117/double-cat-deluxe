using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICatSelectButton : MonoBehaviour
{
    [SerializeField] CatScriptableObject catScriptableObject;
    CatSelectManager catSelectManager;

    void Awake() {
        catSelectManager = GameObject.FindGameObjectWithTag("CatSelectManager").GetComponent<CatSelectManager>();    
    }

    public void selectCat() {
        catSelectManager.selectCatSO(catScriptableObject);
    }
}
