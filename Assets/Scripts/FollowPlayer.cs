using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public int CameraDistance;
    public int velocitySpeed = 0;
    public float smoothTime = 1;

    private Vector3 velocity;
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(player.position.x + CameraDistance, -3.5f, -50), ref velocity, smoothTime);
    }
    private void Start()
    {
        velocity = new Vector3(0, 0, velocitySpeed);
        transform.position = new Vector3(player.position.x + CameraDistance, -3.5f, -50);
    }
}
