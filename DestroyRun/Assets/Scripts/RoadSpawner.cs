using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public List<GameObject> roads;
    [SerializeField] private float offset = 60f;

    // Start is called before the first frame update
    void Start()
    {
        if(roads != null && roads.Count > 0)
        {
            roads = roads.OrderBy(roads => roads.transform.position.z).ToList();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveRoad()
    {
        GameObject moveRoad = roads[0];
        roads.Remove(moveRoad);
        float newZ = roads[roads.Count - 1].transform.position.z + 1570;
        moveRoad.transform.position = new Vector3(0, 0, newZ);
        roads.Add(moveRoad);

    }
}
