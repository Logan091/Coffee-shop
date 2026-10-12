using UnityEngine;

public class NavigationBack2 : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5f;
    int current = 0;

    void Update()
    {
        if (waypoints.Length == 0) return;

        transform.position = Vector3.MoveTowards(
            transform.position,
            waypoints[current].position,
            speed * Time.deltaTime
        );
    }
}