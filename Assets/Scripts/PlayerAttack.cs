using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
    private int _fireRateSeconds = 5;

    [SerializeField] private GameObject shot;
    private float _shootSpeed = 15.0f;
    private Transform _transform;
    private uint _shotCounter = 0;

    void Start()
    {
        _transform = FindObjectOfType<CharacterController>().transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shot shotInstance = Instantiate(shot, _transform.position,
                Quaternion.LookRotation(_transform.forward, _transform.up)).GetComponent<Shot>();
            shotInstance.gameObject.name = $"SHOT_{_shotCounter:D3}";
            shotInstance.Speed = _shootSpeed;
            shotInstance.Direction = _transform.forward;

            _shotCounter++;
        }
    }

    private IEnumerator Shot()
    {
       
       
        // shotInstance.transform.position = _transform.position;
        // shotInstance.transform.rotation =
            yield return new WaitForSeconds(0.3f);
    }
}