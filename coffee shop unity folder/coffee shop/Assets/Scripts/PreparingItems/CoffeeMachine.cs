using UnityEngine;
using System.Collections;

public class CoffeeMachine : MonoBehaviour
{
    public GameObject Object;
    
    private void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        bool CoffeeMachineOn = true;

        {
            if (CoffeeMachineOn)
            {
                Debug.Log("Coffee Brewing..");

                yield return new WaitForSeconds(5f);
            }

            GameObject Red = GameObject.Find("Red");
            Object.SetActive(true);
            Debug.Log("Done!");
        }
    }
}