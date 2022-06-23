using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animals
{
    [SerializeField] private float dogMoveSpeed;
    [SerializeField] private float dogJumpSpeed;
    [SerializeField] private string dogColor;

    [SerializeField] private float dogAgilty;
    [SerializeField] private float dogStrength;
    [SerializeField] private float dogIntelligence;


    public void ViewDogCharacteristics()
    {
        SetMainCharacteristic(dogAgilty, dogStrength, dogIntelligence);
        SetMainCharacteristic(dogMoveSpeed, dogJumpSpeed, dogColor);
    }
}
