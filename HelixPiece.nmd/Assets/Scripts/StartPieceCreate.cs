using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class StartPieceCreate : MonoBehaviour
{
    public GameObject[] piece;

    public GameObject[] diedPiece;

    int count_Piece;
    int count_diedPiece;

    int create = 0;

    private void Start()
    {
        count_Piece = Random.Range(7, 10);
        int n = count_Piece;

        count_diedPiece = 10 - count_Piece;
        int l = count_diedPiece;

        for (int i = 0; i < 12; i++)
        {
            if (create != 11)
            {
                if (12 - i >= n)
                {
                    int m = Random.Range(0, 2);
                    if (m == 1)
                    {
                        piece[i].SetActive(true);
                        create++;
                        n = n - 1;
                    }
                    else
                    {
                        if (l > 0)
                        {
                            diedPiece[i].SetActive(true);
                            create++;
                            l = l - 1;
                        }
                    }
                }
                else
                {
                    piece[i].SetActive(true);
                }
            }
        }
    }
}
