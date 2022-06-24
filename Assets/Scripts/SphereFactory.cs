using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereFactory : MonoBehaviour
{
    [SerializeField] private GameObject sphere;
    [SerializeField] private float radius;
    [SerializeField] private float timeStep;
    [SerializeField] private int count;
    private Vector3 position;


    void Start()
    {
        position = this.transform.position;
        StartCoroutine(SpawnSpheres());
    }

    IEnumerator SpawnSpheres()
    {
        for(int i = count; i > 0; i--)
        {
            Vector3 shperePosition = position;
            shperePosition.x += radius * Random.Range(-1.0f, 1.0f);
            shperePosition.z += radius * Random.Range(-1.0f, 1.0f);
            Instantiate(sphere, shperePosition, Quaternion.identity);
            yield return new WaitForSeconds(timeStep);
        }
        yield break;
    }
}
