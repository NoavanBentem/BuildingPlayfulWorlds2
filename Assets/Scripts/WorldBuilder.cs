using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WorldBuilder : MonoBehaviour
{
    private float size;



    [SerializeField]
    GameObject floor;

    [SerializeField]
    GameObject floorFallDown;

    [SerializeField]
    GameObject floorBase;

    Vector3 lastPos;

    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;

    public Camera cam;

    void Start()
    {
        size = floor.transform.localScale.x;
        lastPos = floor.transform.position;

        for (int x = 0; x < 10; x++)
        {
            SpawnZ();
        }
        SpawnChunkEasy();
        SpawnChunkMedium();
        SpawnChunkHard();
        SpawnChunkMedium();
        SpawnChunkHard();
        SpawnChunkEasy();

    }


    public void SpawnChunkEasy()
    {
        SpawnX();
        SpawnX();
        SpawnX();
        SpawnZ();
        SpawnZ();
        SpawnZ();
        SpawnX();
        SpawnX();
        SpawnX();
        SpawnZ();
        SpawnZ();
        SpawnFall();

    }

    public void SpawnChunkMedium()
    {
        SpawnX();
        SpawnX();
        SpawnZ();
        SpawnZ();
        SpawnX();
        SpawnX();
        SpawnZ();
        SpawnZ();
        SpawnX();
        SpawnX();
        SpawnX();
        SpawnX();
        SpawnZ();
        SpawnZ();
        SpawnX();
        SpawnX();
        SpawnZ();
        SpawnZ();
        SpawnX();
        SpawnX();
        SpawnFall();

    }
        
    public void SpawnChunkHard()
    {

        SpawnX();
        SpawnZ();
        SpawnX();
        SpawnZ();
        SpawnX();
        SpawnZ();
        SpawnX();
        SpawnZ();
        SpawnFall();
    }

    private void SpawnFall()
    {
        GameObject _floor = Instantiate(floorFallDown) as GameObject;
        _floor.transform.position = lastPos + new Vector3(size, 0f, 0f);
        lastPos = _floor.transform.position;

    }

    private void SpawnBase()
    {
        GameObject _floor = Instantiate(floorBase) as GameObject;
        _floor.transform.position = lastPos + new Vector3(size, 0f, 0f);
        lastPos = _floor.transform.position;

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
