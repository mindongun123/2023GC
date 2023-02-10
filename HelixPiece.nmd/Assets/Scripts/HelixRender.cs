using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixRender : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        meshRenderer.material = PlayGames.instance.pieces.material;
    }
}
