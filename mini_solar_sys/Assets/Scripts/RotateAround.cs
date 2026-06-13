using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour
{
    public Transform target;      // the object to rotate around
    public int speed;             // the speed of rotation

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }
    }

    void Update()
    {
        // RotateAround takes three arguments:
        // 1. Position to rotate around
        // 2. Axis to rotate around
        // 3. Degrees per second
        transform.RotateAround(
            target.transform.position,
            target.transform.up,
            speed * Time.deltaTime
        );
    }
}