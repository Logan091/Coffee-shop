using UnityEngine;

public class CalculatingValues : MonoBehaviour
{
    public int n = 24;

    public int CurrentValue;

    void Start()
    {
        n = 4;

        CalculateForN(n);
    }
    
    void CalculateForN(int n)
    {
        CurrentValue = n * 3;

        Debug.Log("your result is " + CurrentValue);
    }

}
