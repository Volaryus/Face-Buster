using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject acnePrefab;
    public float xLimit;
    public float yLimit;
    public float timeToSpawn=5f;
    public float minTimeToSpawn = 1.5f;
    public bool canSpawn = true;
    private void Update()
    {
        if(canSpawn)
        {
            StartCoroutine(Spawn(timeToSpawn));
            if(timeToSpawn>=minTimeToSpawn)
            {
                timeToSpawn -= 0.1f;
            }
        }
    }

    IEnumerator Spawn(float waitTime)
    {
        canSpawn = false;
        float randomX = Random.Range(-xLimit, xLimit);
        float randomY = Random.Range(-yLimit, yLimit);
        Instantiate(acnePrefab,new Vector2(randomX,randomY),Quaternion.identity);
        yield return new WaitForSeconds(waitTime);
        canSpawn = true;

    }
}
