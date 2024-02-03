using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruSpawner : MonoBehaviour
{

    public Birdy birdScript;
    public GameObject borular;
    public float height;
    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));    
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(borular, new Vector3(1, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
