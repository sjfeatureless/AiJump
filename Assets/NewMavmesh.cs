using Unity.AI.Navigation;
using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class NewMavmesh : MonoBehaviour
{
    private NavMeshSurface surface;
    [SerializeField] private int numObby;
    [SerializeField] List<GameObject> obbyPrefab;
    [SerializeField] private Vector2 randomPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        surface = GetComponent<NavMeshSurface>();
        Baker();
    }

    // Update is called once per frame
    private void Baker()
    {
        for(int i = 0; i < numObby; i++)
        {
            int prefabIndex = Random.Range(0, obbyPrefab.Count);
            float xPos = Random.Range(randomPos.x, randomPos.y);
            float zPos = Random.Range(randomPos.x, randomPos.y);

            GameObject newObby = Instantiate(obbyPrefab[prefabIndex]);
            newObby.transform.position = new Vector3(xPos, newObby.transform.position.y, zPos);
        }
        surface.BuildNavMesh();
    }
}
