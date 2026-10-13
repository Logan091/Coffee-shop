using UnityEngine;

public class Microwave : MonoBehaviour
{
    private void OnTriggerEnter(Collider Dough)
    {
        Debug.Log("Baking..");
        Destroy(Dough.gameObject);
    }
}
