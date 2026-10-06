using UnityEngine;

public class ItemDeposit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == RandomItemSelector.selectedItem)
        {
            Debug.Log("Thank you!");
            Destroy(other.gameObject);
        }
        else
        {
            Debug.Log("This isnt what I Ordered??");
        }
    }
}