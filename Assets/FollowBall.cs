using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform Sphere; // Reference to the ball's Transform component

    public Vector3 offset = new Vector3(0f, 5f, -10f); // Adjust this to set the camera's position relative to the ball

    void Update()
    {
        if (Sphere != null)
        {
            // Update the camera's position based on the ball's position
            transform.position = Sphere.position + offset;

            // Make the camera look at the ball
            transform.LookAt(Sphere);
        }
    }
}
