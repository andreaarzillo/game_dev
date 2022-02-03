using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class EnemiesManager : MonoBehaviour
{
    [SerializeField] private GameObject body;
    private GameObject _body;

    [SerializeField] private uint enemyType = 4;
    [SerializeField] private uint enemiesNumber = 20;
    [SerializeField] private GameObject enemyPrefab01;
    [SerializeField] private GameObject enemyPrefab02;
    [SerializeField] private GameObject enemyPrefab03;
    [SerializeField] private GameObject enemyPrefab04;
    [SerializeField] private GameObject enemyPrefab05;
    [SerializeField] private GameObject enemyPrefab06;
    [SerializeField] private GameObject enemyPrefab07;
    [SerializeField] private GameObject enemyPrefab08;

    [SerializeField] private uint locationsNumber = 4;
    [SerializeField] private GameObject deployLocation01;
    [SerializeField] private GameObject deployLocation02;
    [SerializeField] private GameObject deployLocation03;
    [SerializeField] private GameObject deployLocation04;
    [SerializeField] private GameObject deployLocation05;
    [SerializeField] private GameObject deployLocation06;
    [SerializeField] private GameObject deployLocation07;
    [SerializeField] private GameObject deployLocation08;

    // private const uint NumEnemies01 = 5;
    // private const uint NumEnemies02 = 5;
    // private const uint NumEnemies03 = 5;
    // private const uint NumEnemies04 = 5;

    // private readonly Vector3 _deployLocation01 = new(0.1f, 0.1f, 0.1f);
    // private readonly Vector3 _deployLocation02 = new(0.2f, 0.1f, 0.1f);
    // private readonly Vector3 _deployLocation03 = new(0.3f, 0.1f, 0.1f);
    // private readonly Vector3 _deployLocation04 = new(0.4f, 0.1f, 0.1f);
    private List<GameObject> _enemies;


    private void Awake()
    {
        GenerateEnemies();
        GenerateBody();
    }

    private void GenerateEnemies()
    {
        if (_enemies == null)
            _enemies = new List<GameObject>();

        uint totEnemies = enemiesNumber;

        while (totEnemies != 0)
        {
            int toCreate = Random.Range(1, (int) (totEnemies < 5 ? totEnemies : 5));

            switch (Random.Range(1, (int) (enemyType + 1)))
            {
                case 1:
                    if (enemyPrefab01 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab01));
                            totEnemies--;
                        }

                    break;
                case 2:
                    if (enemyPrefab02 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab02));
                            totEnemies--;
                        }

                    break;
                case 3:
                    if (enemyPrefab03 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab03));
                            totEnemies--;
                        }

                    break;
                case 4:
                    if (enemyPrefab04 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab04));
                            totEnemies--;
                        }

                    break;
                case 5:
                    if (enemyPrefab05 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab05));
                            totEnemies--;
                        }

                    break;
                case 6:
                    if (enemyPrefab06 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab06));
                            totEnemies--;
                        }

                    break;
                case 7:
                    if (enemyPrefab07 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab07));
                            totEnemies--;
                        }

                    break;
                case 8:
                    if (enemyPrefab08 != null)
                        for (int i = 0; i < toCreate; i++)
                        {
                            _enemies.Add(Instantiate(enemyPrefab08));
                            totEnemies--;
                        }

                    break;
            }
        }
    }

    private void GenerateBody()
    {
        if (body == null && body != null) Instantiate(body);
    }

    private void Start()
    {
        DeployBody();
        DeployEnemies();
    }

    private void DeployBody()
    {
        switch (Random.Range(1, (int) (locationsNumber + 1)))
        {
            case 1:
                if (deployLocation01 != null)
                    _body.transform.position = deployLocation01.transform.position;

                break;
            case 2:
                if (deployLocation02 != null)
                    _body.transform.position = deployLocation02.transform.position;

                break;
            case 3:
                if (deployLocation03 != null)
                    _body.transform.position = deployLocation03.transform.position;

                break;
            case 4:
                if (deployLocation04 != null)
                    _body.transform.position = deployLocation04.transform.position;

                break;
            case 5:
                if (deployLocation01 != null)
                    _body.transform.position = deployLocation01.transform.position;

                break;
            case 6:
                if (deployLocation02 != null)
                    _body.transform.position = deployLocation02.transform.position;

                break;
            case 7:
                if (deployLocation03 != null)
                    _body.transform.position = deployLocation03.transform.position;

                break;
            case 8:
                if (deployLocation04 != null)
                    _body.transform.position = deployLocation04.transform.position;

                break;
        }
    }

    private void DeployEnemies()
    {
        if (_enemies == null || _enemies.Count == 0)
            return;

        for (int i = 0; i < _enemies.Count;)
        {
            switch (Random.Range(1, (int) (locationsNumber + 1)))
            {
                case 1:
                    if (deployLocation01 != null)
                    {
                        _enemies[i].transform.position = deployLocation01.transform.position;
                        i++;
                    }

                    break;
                case 2:
                    if (deployLocation02 != null)
                    {
                        _enemies[i].transform.position = deployLocation02.transform.position;
                        i++;
                    }

                    break;
                case 3:
                    if (deployLocation03 != null)
                    {
                        _enemies[i].transform.position = deployLocation03.transform.position;
                        i++;
                    }

                    break;
                case 4:
                    if (deployLocation04 != null)
                    {
                        _enemies[i].transform.position = deployLocation04.transform.position;
                        i++;
                    }

                    break;
                case 5:
                    if (deployLocation01 != null)
                    {
                        _enemies[i].transform.position = deployLocation01.transform.position;
                        i++;
                    }

                    break;
                case 6:
                    if (deployLocation02 != null)
                    {
                        _enemies[i].transform.position = deployLocation02.transform.position;
                        i++;
                    }

                    break;
                case 7:
                    if (deployLocation03 != null)
                    {
                        _enemies[i].transform.position = deployLocation03.transform.position;
                        i++;
                    }

                    break;
                case 8:
                    if (deployLocation04 != null)
                    {
                        _enemies[i].transform.position = deployLocation04.transform.position;
                        i++;
                    }

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