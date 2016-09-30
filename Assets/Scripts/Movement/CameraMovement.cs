using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    //Made by Danny Kruiswijk

    [SerializeField] private Transform cameraFollowPoint;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;

    void Start () {
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z);
    }
	
	void Update () {
        Vector3 newCameraFollowPosition = cameraFollowPoint.transform.position;
        transform.position = Vector3.Lerp(transform.position, newCameraFollowPosition, smoothTime*Time.deltaTime);
        transform.LookAt(target);
    }
}