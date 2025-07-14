using UnityEngine;
using UnityEngine.Tilemaps;

public class TilemapPlacer : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject towerPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // clic gauche
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPos = tilemap.WorldToCell(mouseWorldPos);
            Vector3 spawnPos = tilemap.GetCellCenterWorld(cellPos);

            Instantiate(towerPrefab, spawnPos, Quaternion.identity);
        }
    }
}
