using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animals : MonoBehaviour
{
    // ENCAPSULATION
    public float moveSpeed { get; private set; }
    public float jumpSpeed { get; private set; }
    public float agility { get; private set; }
    public float intelligence { get; private set; }
    public float strength { get; private set; }
    public string color { get; private set; }

    public Text comment;

    private void Start()
    {
        comment.text = "Select an object to view characteristics";
    }
    // POLYMORPHISM
    // ABSTRACTION
    public void SetMainCharacteristic( float agility, float strength, float intelligence)
    {
        comment.text = "Agility - " + agility + "\n" + "Strength - " + strength + "\n" + "Intelegence - " + intelligence;
    }

    public void SetMainCharacteristic(float moveSpeed, float jumpSpeed, string color)
    {
        comment.text += "\n" + "Move speed - " + moveSpeed + "\n" + "Jump Speed - " + jumpSpeed + "\n" + "Color - " + color;
    }


}
