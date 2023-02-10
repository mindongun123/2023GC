using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGamePlay : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Vector3.up, -Input.GetAxis("Mouse X") * 10f, Space.World);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {
            PlayGames.instance.CreateStepPiece(transform.position - new Vector3(0, 12, 0));
            Destroy(gameObject);
        }
    }
}
