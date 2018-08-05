using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float size;

    [SerializeField]
    GameObject floor;

    Vector3 lastPos;

    void Start()
    {
        size = floor.transform.localScale.x;
        lastPos = floor.transform.position;

        for (int x = 0; x < 24; x++)
        {
            SpawnZ();
        }
        InvokeRepeating("SpawnPlatform", 2f, 0.2f);
    }


    private void SpawnPlatform()
    {
        int random = Random.Range(0, 6);
        if(random < 3)
        {
            SpawnX();
        }
        if(random >= 3)
        {
            SpawnZ();
        }
    }

    private void SpawnX()
    {
        GameObject _floor = Instantiate(floor) as GameObject;
        _floor.transform.position = lastPos + new Vector3(size, 0f, 0f);
        lastPos = _floor.transform.position;

    }

    private void SpawnZ()
    {
        GameObject _floor = Instantiate(floor) as GameObject;
        _floor.transform.position = lastPos + new Vector3(0f, 0f, size);
        lastPos = _floor.transform.position;
    }
}
