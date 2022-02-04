using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(Rigidbody))]
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3.0f;
    [SerializeField] private float obstacleRange = 5.0f;
    [SerializeField] private string obstacleTag = "Obstacle";

    private Vector3 _position;
    private Vector3 _rotation;
    private Rigidbody _rigidbody;
    private bool _isDeployed;
    private float _gravity;
    private const float WaterHeight = 15.5f;

    void Awake()
    {
        Messenger.AddListener(GameEvent.ENEMIES_DEPLOYED, Deployed);
        _rigidbody = GetComponent<Rigidbody>();
        _isDeployed = false;
        _gravity = -9.8f;
    }

    private void Deployed()
    {
        _isDeployed = !_isDeployed;
        _position = transform.localPosition;
    }

    void FixedUpdate()
    {
        if (!_isDeployed)
            return;


        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        
        if (Physics.SphereCast(ray, 0.75f, out hit))
        {
            if (hit.collider != null && hit.distance < obstacleRange)
            {
                float angle = Random.Range(-110, 110);
                _rigidbody.MoveRotation(Quaternion.Euler(new Vector3(0, angle, 0)) * transform.localRotation);
            }
        }
        
        _position += Time.fixedDeltaTime * speed * transform.forward;
        _rigidbody.MovePosition(_position);
    }

    private void OnDestroy()
    {
        Messenger.RemoveListener(GameEvent.ENEMIES_DEPLOYED, Deployed);
    }
}