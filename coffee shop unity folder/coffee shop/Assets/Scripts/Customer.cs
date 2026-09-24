using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    //variables
    public static string drinkType = "Coffee";
    //static means that it is per class, and not per instance of a class

    public string exampleVariable = "Tea";

    public UnityEvent raiseOrder;

    void Start()
    {
        RequestDrink(drinkType);
    }

    public void RequestDrink(string drinkType)
    {
        Debug.Log(drinkType);
        raiseOrder?.Invoke();
        Debug.Log(exampleVariable);
    }
}

