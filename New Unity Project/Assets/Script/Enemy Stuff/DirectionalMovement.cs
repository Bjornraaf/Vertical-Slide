using UnityEngine;
using System.Collections;

public class DirectionalMovement : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private float height = 4.0f;
    [SerializeField] private float speed = 2.0f;

    public void Update()
    {
        float movement = Mathf.PingPong(Time.time, 1) * height ;
        Vector3 newPosition = direction * movement;
        transform.Translate(newPosition * Time.deltaTime * speed);
    }
}