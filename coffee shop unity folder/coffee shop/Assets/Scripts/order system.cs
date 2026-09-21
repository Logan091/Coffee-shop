using UnityEngine;

public class ordersystem : MonoBehaviour
{
   //camel Casing -> variables
   private float _costOfCoffee = 3.5f;

   public int coffeeAmountOrdered;

   public float totalOrderAmount;
   
   //pascal casing -> Method, Classes, Properties
   public void AmountPlaced(int coffeeAmountOrdered)
   {
    totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
    Debug.Log("Your Order Amount Today Is" + " £ " + totalOrderAmount);
   }
}

//Access Modifers
//void -> private void
//void
// public void -> public void

//if public, can be seen outside class (script)
//if private, cant be seen outside class (script)