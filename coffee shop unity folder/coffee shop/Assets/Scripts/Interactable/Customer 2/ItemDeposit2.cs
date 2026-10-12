using UnityEngine;

public class ItemDeposit2 : MonoBehaviour
{
    private NavigationBack2 otherScript;
    private Navigation3 otherScript2;

    void Start()
    {
        otherScript = GetComponent<NavigationBack2>();
        GameObject Customer3 = GameObject.Find("Customer3");
        otherScript2 = Customer3.GetComponent<Navigation3>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == RandomItemSelector2.selectedItem)
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