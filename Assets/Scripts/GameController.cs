using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text parametr;

    public void OnChangeClass()
    {
        parametr.text = "Select an object to view characteristics";
    }
    public void OnChangeClassToWheather()
    {
        parametr.text = "Like and I will finish the variation for the weather! =)";
    }
}
