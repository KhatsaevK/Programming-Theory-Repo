using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animals
{
    [SerializeField] private float catMoveSpeed;
    [SerializeField] private float catJumpSpeed;
    [SerializeField] private string catColor;

    [SerializeField] private float catAgilty;
    [SerializeField] private float catStrength;
    [SerializeField] private float catIntelligence;


    public void ViewCatCharacteristics()
    {
        SetMainCharacteristic(catAgilty, catStrength, catIntelligence);
        SetMainCharacteristic(catMoveSpeed, catJumpSpeed, catColor);
    }
}
