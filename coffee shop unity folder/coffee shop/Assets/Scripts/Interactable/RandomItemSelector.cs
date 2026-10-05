using UnityEngine;
using System.Collections.Generic;

public class RandomObjectSelector : MonoBehaviour
{
    [SerializeField] private List<GameObject> gameObjects = new List<GameObject>();

    public static GameObject selectedItem;

    void Start()
    {
        selectedItem = gameObjects[Random.Range(0, gameObjects.Count)];

        Debug.Log($"Please Can I Have: {selectedItem.name}");
    }
}