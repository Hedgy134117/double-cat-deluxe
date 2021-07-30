using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    public void displayScore(List<Cat> cats) {
        scoreText.text = "";
        foreach (Cat cat in cats)
        {
            scoreText.text += cat.catScriptableObject.name + ": " + cat.points.ToString() + "\n";
        }
    }
}
