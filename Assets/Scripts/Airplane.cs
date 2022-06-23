using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane : Vehicle
{
    [SerializeField] private float airMoveSpeed;
    [SerializeField] private float airTirnSpeed;
    [SerializeField] private string airColor;

    [SerializeField] private string noFlightCriminalRecord;
    [SerializeField] private float requiredFlightExperience;
    [SerializeField] private float airRequiredAge;

    public void ViewAirCharactiristics()
    {
        SetMainCharacteristic(noFlightCriminalRecord, requiredFlightExperience, airRequiredAge);
        SetMainCharacteristic(airMoveSpeed, airTirnSpeed, airColor);
    }
}
