using UnityEngine;

public class Coffeeshoptest : MonoBehaviour
{
    public int coffeesSold = 0;
    public float coffeePrice = 3.50f;

    void Start()
    {
        Debug.Log("Coffees sold: " + coffeesSold);
    }

    void AddCoffee()
    {
        coffeesSold =+ 1;
    }
}