using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CameraScript : MonoBehaviour
{
    public Transform cameraT;

    void FixedUpdate()
    {
        if(SceneManager.GetActiveScene().name.Equals("Dropping"))
            {
                if (transform.position.y < cameraT.position.y) {
                    cameraT.position = new Vector3(0f, transform.position.y, cameraT.position.z);
            }
            }
        if(SceneManager.GetActiveScene().name.Equals("Jumping"))
            {
                cameraT.position = new Vector3(transform.position.x, 0, cameraT.position.z);
            }

    }

}
