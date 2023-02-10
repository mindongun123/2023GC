using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FX : MonoBehaviour
{

    public SpriteRenderer spriteBolt;
    public ParticleSystem particle;

    public Material material;

    [System.Obsolete]

    private void Start()
    {
        particle.startColor = PlayGames.instance.ball.material.color;
        material.color = PlayGames.instance.ball.material.color;
    }
    private void Update()
    {
        spriteBolt.color = PlayGames.instance.ball.material.color;
    }
}
