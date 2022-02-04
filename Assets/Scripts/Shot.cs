using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Shot : MonoBehaviour
{
    private float _speed = 15.0f;
    private Vector3 _direction;
    private float _lifeTime = 5.0f;
    private Rigidbody _rigidbody;

    public Vector3 Direction
    {
        set { _direction = value; }
    }
    
    public float Speed
    {
        set { _speed = value; }
    }

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        _rigidbody.AddForce(_direction * _speed, ForceMode.VelocityChange);
    }

    void Update()
    {
        _lifeTime -= Time.deltaTime;
        if (_lifeTime <= 0f)
        {
            StartCoroutine(DestroyRoutine(0.3f));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // StartCoroutine(DestroyRoutine(0.3f));
    }

    private IEnumerator DestroyRoutine(float time)
    {
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
        _rigidbody.detectCollisions = false;
        _rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
        _rigidbody.isKinematic = true;
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}