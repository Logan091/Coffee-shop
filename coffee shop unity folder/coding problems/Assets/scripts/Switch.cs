using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino,
        None
    }

    [SerializeField] private CoffeeType coffeeOrder = CoffeeType.Latte;
    
    void Start()
    {
        switch (coffeeOrder)
        {
            case "Espresso":
                Debug.Log("Making a Espresso");
                break;
            case "Latte":
                Debug.Log("Preparing a Latte");
                break;
            case "Cappuccino":
                Debug.Log("Pouring a Latte");
                break;
            default:
                Debug.Log("We dont have that");
                break;
        }
    }
}
