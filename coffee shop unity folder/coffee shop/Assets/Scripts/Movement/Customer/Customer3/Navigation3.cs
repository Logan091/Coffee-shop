using UnityEngine;

public class Navigation3 : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 3f;
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