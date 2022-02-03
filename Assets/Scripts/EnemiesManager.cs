using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemiesManager : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab01;
    [SerializeField] private GameObject enemyPrefab02;
    [SerializeField] private GameObject enemyPrefab03;
    [SerializeField] private GameObject enemyPrefab04;
    [SerializeField] private GameObject deployLocation01;
    [SerializeField] private GameObject deployLocation02;
    [SerializeField] private GameObject deployLocation03;
    [SerializeField] private GameObject deployLocation04;
    private const uint NumEnemies01 = 5;
    private const uint NumEnemies02 = 5;
    private const uint NumEnemies03 = 5;
    private const uint NumEnemies04 = 5;

    // private readonly Vector3 _deployLocation01 = new(0.1f, 0.1f, 0.1f);
    // private readonly Vector3 _deployLocation02 = new(0.2f, 0.1f, 0.1f);
    // private readonly Vector3 _deployLocation03 = new(0.3f, 0.1f, 0.1f);
    // private readonly Vector3 _deployLocation04 = new(0.4f, 0.1f, 0.1f);
    private List<GameObject> _enemies;


    private void Awake()
    {
        CreateEnemies();
    }

    private void CreateEnemies()
    {
        if (_enemies == null)
            _enemies = new List<GameObject>();

        if (enemyPrefab01 != null)
            for (int i = 0; i < NumEnemies01; i++)
                _enemies.Add(Instantiate(enemyPrefab01));

        if (enemyPrefab02 != null)
            for (int i = 0; i < NumEnemies02; i++)
                _enemies.Add(Instantiate(enemyPrefab02));

        if (enemyPrefab02 != null)
            for (int i = 0; i < NumEnemies03; i++)
                _enemies.Add(Instantiate(enemyPrefab03));

        if (enemyPrefab02 != null)
            for (int i = 0; i < NumEnemies04; i++)
                _enemies.Add(Instantiate(enemyPrefab04));
    }

    private void Start()
    {
        DeployEnemies();
    }

    private void DeployEnemies()
    {
        if (_enemies == null || _enemies.Count == 0)
            return;

        foreach (var enemy in _enemies)
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    if (deployLocation01 != null)
                        enemy.transform.position = deployLocation01.transform.position;
                    break;
                case 2:
                    if (deployLocation02 != null)
                        enemy.transform.position = deployLocation02.transform.position;
                    break;
                case 3:
                    if (deployLocation03 != null)
                        enemy.transform.position = deployLocation03.transform.position;
                    break;
                case 4:
                    if (deployLocation04 != null)
                        enemy.transform.position = deployLocation04.transform.position;
                    break;
            }
        }
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
    }
}