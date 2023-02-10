using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Ball : MonoBehaviour
{
    public Rigidbody ri;
    public Vector3 trn = new Vector3();

    [Header("FX")]
    public GameObject Fx_BoltPrefabs;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("piece"))
        {
            AudioGame.instance.AuBolt();
            CreateFX(other.transform);
            Jump();
        }
        if (other.gameObject.CompareTag("diedpiece"))
        {
            AudioGame.instance.AuBolt();
            CreateFX(other.transform);
            GameManager.IsGameOver = true;
        }
    }

    public float a, b;
    public void CreateFX(Transform trn)
    {
        GameObject fx_bolt = Instantiate(Fx_BoltPrefabs, trn, false);
        fx_bolt.transform.position = new Vector3(trn.position.x, trn.transform.position.y + a, trn.transform.position.z - b);
        fx_bolt.transform.rotation = Quaternion.Euler(90f, 0, Random.Range(0, 360f));
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("stepplatform"))
        {
            if (GameManager.IsGameOver == false)
            {
                AudioGame.instance.AuCoin();
                GameManager.score++;
            }
            CameraFollow.instance.checkStep = true;
        }
    }

    private void Jump()
    {
        ri.velocity = new Vector3(0f, 5.5f, 0f);
    }
}
