using UnityEngine;

public class Speech : MonoBehaviour
{
    public string[] menu = { "Coffee", "Tea", "Donut", "Cake" };

    void Start()
    {
        int randomIndex = Random.Range(0, menu.Length);

        string chosenItem = menu[randomIndex];
        Debug.Log("Can I Have A " + chosenItem + " Please");
    }
}