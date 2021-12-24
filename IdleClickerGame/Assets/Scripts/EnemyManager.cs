using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject[] EnemyPrefabs;
    public Enemy CurrentEnemy;
    public Transform Canvas;

    public static EnemyManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void CreateNewEnemy()
    {
        GameObject enemyToSpawn = EnemyPrefabs[Random.Range(0, EnemyPrefabs.Length)];
        GameObject obj = Instantiate(enemyToSpawn, Canvas);

        CurrentEnemy = obj.GetComponent<Enemy>();
    }

    public void DefeatEnemy(GameObject enemy)
    {
        Destroy(enemy);
        CreateNewEnemy();
        GameManager.Instance.BackgroundCheck();
    }
}
