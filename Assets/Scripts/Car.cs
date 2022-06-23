using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    [SerializeField] private float carMoveSpeed;
    [SerializeField] private float carTirnSpeed;
    [SerializeField] private string carColor;

    [SerializeField] private string noDriveCriminalRecord;
    [SerializeField] private float requiredDrivingExperience;
    [SerializeField] private float carRequiredAge;

    public void ViewCarCharactiristics()
    {
        SetMainCharacteristic(noDriveCriminalRecord, requiredDrivingExperience, carRequiredAge);
        SetMainCharacteristic(carMoveSpeed, carTirnSpeed, carColor);
    }
}
