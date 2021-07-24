using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ControlScheme
{
    WASD,
    ARROWS,
    UHJK
}

public class CatSetter : MonoBehaviour
{
    public Cat cat;
    public CatScriptableObject catScriptableObject;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] CatMovement catMovement;
    
    void Start() {
        catScriptableObject = cat.catScriptableObject;
        setVisuals();
        setCollider();
        setMovement();
    }

    void setVisuals() {
        transform.localScale = catScriptableObject.scale;
        spriteRenderer.sprite = catScriptableObject.sprite;
    }

    void setCollider() {
        gameObject.AddComponent<BoxCollider2D>(); // TEMP COLLIDER
    }

    void setMovement() {
        catMovement.speedScale = catScriptableObject.speedScale;
        // connect each control scheme with the move function
        switch(cat.controlScheme) {
            case ControlScheme.WASD:
                catMovement.controls.WASDPlayer.Movement.performed += ctx => catMovement.move(ctx.ReadValue<Vector2>());
                break;
            case ControlScheme.ARROWS:
                catMovement.controls.ARROWSPlayer.Movement.performed += ctx => catMovement.move(ctx.ReadValue<Vector2>());
                break;
            case ControlScheme.UHJK:
                catMovement.controls.UHJKPlayer.Movement.performed += ctx => catMovement.move(ctx.ReadValue<Vector2>());
                break;
        }
    }
}
