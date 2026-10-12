using UnityEngine;

public class ItemDeposit : MonoBehaviour
{
    private NavigationBack otherScript;
    private Navigation2 otherScript2;

    void Start()
    {
        otherScript = GetComponent<NavigationBack>();
        GameObject Customer2 = GameObject.Find("Customer2");
        otherScript2 = Customer2.GetComponent<Navigation2>();
    }

    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject == RandomItemSelector.selectedItem)
        {
            Debug.Log("Thank you!");
            Destroy(other.gameObject);

            otherScript.enabled = true;
            otherScript2.enabled = true;
        }
        else
        {
            Debug.Log("This isnt what I Ordered??");
        }
    }
}