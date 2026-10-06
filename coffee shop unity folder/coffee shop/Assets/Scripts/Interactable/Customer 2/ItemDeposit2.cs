using UnityEngine;

public class ItemDeposit2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == RandomItemSelector2.selectedItem)
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