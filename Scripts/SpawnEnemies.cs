using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;
    public int numbOfEnemiesleft = 0;
    public int numbOfEnemiesright = 0;
    public int numbOfEnemiesback = 0;
    public int numbOfEnemiesforward = 0;

    public int maxEnemiesLeft = 3;
    public int maxEnemiesRight = 3;
    public int maxEnemiesFront = 2;
    public int maxEnemiesBack = 2;
    void Start()
    {
        StartCoroutine(EnemySpawnLeft());
        StartCoroutine(EnemySpawnRight());
        StartCoroutine(EnemySpawnFront());
        StartCoroutine(EnemySpawnBack());
    }

    IEnumerator EnemySpawnLeft()
    {
        while(numbOfEnemiesleft < maxEnemiesLeft)
        {
            xPos = Random.Range(-60, -80);
            zPos = Random.Range(-0, -20);
            Instantiate(enemy, new Vector3(xPos, 1.89f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f,4f));
            numbOfEnemiesleft++;
        }
    }

    IEnumerator EnemySpawnRight()
    {
        while (numbOfEnemiesright < maxEnemiesRight)
        {
            xPos = Random.Range(60, 80);
            zPos = Random.Range(-0, -20);
            Instantiate(enemy, new Vector3(xPos, 1.89f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 4f));
            numbOfEnemiesright++;
        }
    }

    IEnumerator EnemySpawnFront()
    {
        while (numbOfEnemiesforward < maxEnemiesFront)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(-60, -80);
            Instantiate(enemy, new Vector3(xPos, 1.89f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 4f));
            numbOfEnemiesforward++;
        }
    }

    IEnumerator EnemySpawnBack()
    {
        while (numbOfEnemiesback < maxEnemiesBack)
        {
            xPos = Random.Range(-20, 20);
            zPos = Random.Range(60, 80);
            Instantiate(enemy, new Vector3(xPos, 1.89f, zPos), Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1f, 4f));
            numbOfEnemiesback++;
        }
    }
}
