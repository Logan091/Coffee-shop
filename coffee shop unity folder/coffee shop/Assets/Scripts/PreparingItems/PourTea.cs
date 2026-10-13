using UnityEngine;
using System.Collections;

public class PourTea : MonoBehaviour
{
    public GameObject Object;

    private void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        Debug.Log("Pouring Tea..");

        yield return new WaitForSeconds(5f);

        GameObject Pink = GameObject.Find("Pink");
        Object.SetActive(true);
        Debug.Log("Done!");
    }
}