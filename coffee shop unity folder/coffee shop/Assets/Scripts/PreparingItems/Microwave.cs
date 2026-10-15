using UnityEngine;
using System.Collections;

public class Microwave : MonoBehaviour
{
    public GameObject Object;
    private bool isBaking = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Dough" && !isBaking)
        {
            StartCoroutine(BakeDough(other.gameObject));
        }
    }

    IEnumerator BakeDough(GameObject doughObj)
    {
        isBaking = true;
        Debug.Log("Baking..");
        Destroy(doughObj);

        yield return new WaitForSeconds(5f);

        GameObject Cyan = GameObject.Find("Cyan");
        if (Object != null)
        {
            Object.SetActive(true);
        }
        Debug.Log("Done!");
        isBaking = false;
    }
}
