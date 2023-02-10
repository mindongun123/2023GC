using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelixDiedRender : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Start() {
        
        meshRenderer.material = PlayGames.instance.died_pieces.material;
    }

}
