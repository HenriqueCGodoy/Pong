using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rb;

    [SerializeField]
    private float speed = 200.0f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1 : 1;
        float y = Random.value < 0.5f ? Random.Range(0.5f, 1.0f) : Random.Range(-1.0f, 0.5f);

        Vector2 direction = new Vector2(x, y);

        _rb.AddForce(direction * speed);
    }

    public void AddForce(Vector2 force)
    {
        _rb.AddForce(force);
    }

    public void ResetPosition()
    {
        _rb.position = Vector3.zero;
        _rb.velocity = Vector3.zero;
    }
}
