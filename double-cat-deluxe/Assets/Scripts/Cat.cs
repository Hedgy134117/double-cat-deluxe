using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cat
{
    public CatScriptableObject catScriptableObject;
    public ControlScheme controlScheme;

    public Cat(CatScriptableObject catScriptableObject, ControlScheme controlScheme) {
        this.catScriptableObject = catScriptableObject;
        this.controlScheme = controlScheme;
    }
}
