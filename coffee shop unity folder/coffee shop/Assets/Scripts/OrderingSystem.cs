using UnityEngine;

public class OrderingSystem : MonoBehaviour
{
    private float _costOfCoffee = 3.5f;

    private int coffeeAmountOrdered;

    private float totalOrderAmount;

    void Start()
    {
        AmountPlaced(5);
    }

    public void AmountPlaced(int coffeeAmountOrdered)
    {
        totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
        Debug.Log("Your Order Amount Today Is" + " £ " + totalOrderAmount);
    }
}
