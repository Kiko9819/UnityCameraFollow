using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    public GameObject player;
    public float timeOffset = 2.5f;
    public bool canMoveY = false;

    private void FixedUpdate()
    {
        Vector3 startPosition = transform.position;
        Vector3 endPosition = player.transform.position;

        if(!canMoveY)
        {
            endPosition.y = 0;
        }
        endPosition.z = -10;

        transform.position = Vector3.Lerp(startPosition, endPosition, Time.fixedDeltaTime * timeOffset);
    }
}
