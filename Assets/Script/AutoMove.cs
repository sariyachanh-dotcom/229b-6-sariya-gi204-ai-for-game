using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Move forward automatically
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}