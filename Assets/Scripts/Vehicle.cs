using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vehicle : MonoBehaviour
{
    // ENCAPSULATION
    public float moveSpeed { get; private set; }
    public float tirnSpeed { get; private set; }
    public string color { get; private set; }

    public string noCriminalRecord { get; private set; }
    public float requiredExperience { get; private set; }
    public float requiredAge { get; private set; }


    public Text comment;

    private void Start()
    {
        comment.text = "Select an object to view characteristics";
    }
    // POLYMORPHISM
    // ABSTRACTION
    public void SetMainCharacteristic(string noCriminalRecord, float requiredExperience, float requiredAge)
    {
        comment.text = "Criminal Record - " + noCriminalRecord+ "\n" + "Required experience - " + requiredExperience + "\n" + "Required age - " + requiredAge;
    }

    public void SetMainCharacteristic(float moveSpeed, float tirnSpeed, string color)
    {
        comment.text += "\n" + "Move speed - " + moveSpeed + "\n" + "Tirn Speed - " + tirnSpeed + "\n" + "Color - " + color;
    }
    
}
