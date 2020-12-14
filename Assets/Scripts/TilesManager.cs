using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilesManager : MonoBehaviour
{
    public GameObject[] tilePrefabs;

    private Transform playerTransform;
    private float spawnY = 5.0f;
    private float tileHeight = 1.0f;
    private float spaceBetweenEveryTiles = 5.0f;

    private int amnTilsOnScreen = 7;

    private int tilsIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        SpawnTile();
    }


    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y > (spawnY - 13 - amnTilsOnScreen * tileHeight))
        {
            SpawnTile();
        }
    }

    private void SpawnTile(int prefabIndex = -1)
    {
        GameObject go;
        if (tilsIndex == 0)
        {
            go = Instantiate(tilePrefabs[0]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = new Vector3(-26, -21, -1);
        }
        else if (tilsIndex == 1 || tilsIndex == 6 || tilsIndex == 11 || tilsIndex == 16)
        {
            go = Instantiate(tilePrefabs[2]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = new Vector3(-26, -21, -1);
        }
        else if (tilsIndex % 3 == 0 && tilsIndex % 5 != 0)
        {
            go = Instantiate(tilePrefabs[2]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = new Vector3(-26, -21, -1);
        }
        else if (tilsIndex % 5 == 0 && tilsIndex % 3 != 0)
        {
            go = Instantiate(tilePrefabs[0]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = new Vector3(-26, -21, -1);
        }
        else
        {
            go = Instantiate(tilePrefabs[1]) as GameObject;
            go.transform.SetParent(transform);
            go.transform.position = new Vector3(-40, -21, -1);
        }

        go.transform.position += Vector3.up * spawnY;
        spawnY += (tileHeight + spaceBetweenEveryTiles);
        tilsIndex++;
    }
}
