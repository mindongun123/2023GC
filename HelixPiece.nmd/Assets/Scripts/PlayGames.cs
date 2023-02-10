using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayGames : MonoBehaviour
{
    public static PlayGames instance;

    [Header("Setting Game")]
    public MeshRenderer[] PieceSettingStart;
    public MeshRenderer[] DiedPieceSettingStart;

    [Header("Create Step Piece")]
    public GameObject start_piecePrefabs;
    public GameObject pivotPrefabs;

    [Header("Material")]
    public List<Material> _materials;

    [Header("Mesh Reneder")]
    public MeshRenderer pivotPieces;
    public MeshRenderer ball;
    public MeshRenderer pieces;
    public MeshRenderer died_pieces;

    [Header("UI")]

    public GameObject UI_gameOver;

    [Header("ID")]
    public int id_piece;
    public int id_died_piece;
    public int is_pivot;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        SettingStartGame_materials();
        CreatePivotPieces(new Vector3(0, -40, 0), new Vector3(0, 0, 0));

        UI_gameOver.SetActive(false);
    }


    private void SettingStartGame_materials()
    {
        pivotPieces.material = _materials[Random.Range(0, _materials.Count)];
        ball.material = _materials[Random.Range(0, _materials.Count)];

        id_piece = Random.Range(0, _materials.Count);
        pieces.material = _materials[id_piece];


        id_died_piece = Random.Range(0, _materials.Count);

        while (id_died_piece == id_piece)
        {
            id_died_piece = Random.Range(0, _materials.Count);
        }
        died_pieces.material = _materials[id_died_piece];

        // cai dat stepPiece ban dau
        for (int i = 0; i < PieceSettingStart.Length; i++)
        {
            PieceSettingStart[i].material = _materials[id_piece];
        }
        for (int i = 0; i < DiedPieceSettingStart.Length; i++)
        {
            DiedPieceSettingStart[i].material = _materials[id_died_piece];
        }
    }

    public void CreateStepPiece(Vector3 location)
    {
        GameObject _stepPiece = Instantiate(start_piecePrefabs, location, transform.rotation);
        is_pivot = is_pivot + 1;
        if (is_pivot == 25)
        {
            CreatePivotPieces(location, new Vector3(0, -50, 0));
            is_pivot = 0;
        }
    }

    public void CreatePivotPieces(Vector3 location, Vector3 next)
    {
        GameObject _pivot = Instantiate(pivotPrefabs, location - next, transform.rotation);
    }
}
