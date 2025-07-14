using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TowerPlacer : MonoBehaviour
{
    public Tilemap tilemap;               // la grille
    public GameObject towerPrefab;        // prefab de tour à placer

    private HashSet<Vector3Int> occupiedCells = new HashSet<Vector3Int>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // clic gauche
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int cellPos = tilemap.WorldToCell(mouseWorldPos);

            // Si la cellule est déjà occupée → on bloque
            if (occupiedCells.Contains(cellPos))
            {
                Debug.Log("Une tour est déjà placée ici !");
                return;
            }

            // Sinon, on instancie la tour
            Vector3 spawnPos = tilemap.GetCellCenterWorld(cellPos);
            spawnPos.z = -1f; // s'assurer qu'elle s'affiche au-dessus de la grille

            Instantiate(towerPrefab, spawnPos, Quaternion.identity);
            occupiedCells.Add(cellPos); // marquer cette case comme occupée
        }
    }
}
