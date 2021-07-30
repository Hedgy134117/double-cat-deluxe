using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Cat", menuName = "double-cat-deluxe/Cat", order = 0)]
public class CatScriptableObject : ScriptableObject {
  public Sprite sprite;
  public Vector2 scale = new Vector2(1, 1);
  public Vector2 speedScale = new Vector2(200, 500);
}