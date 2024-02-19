using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Transform Sphere; // Reference to the ball's Transform component

    //public Vector3 offset = new Vector3(0f, 5f, -10f); // Adjust this to set the camera's position relative to the ball
        public float rotationSpeed = 2f; 
    public float distanceFromTarget = 5f; // Etäisyys pallosta
    public float perspectiveHeight = 20f; // Kameran korkeus pallosta

  
    private float rotationY = 0f;
    void Update()
    {
        if (Sphere != null)
        {
            // Update the camera's position based on the ball's position
            //transform.position = Sphere.position + offset;
            //transform.LookAt(Sphere);
             transform.position = Sphere.position;

            // Käännä kameraa hiiren liikkeen mukaisesti
  

            // Käännä kameraa hiiren liikkeen mukaisesti
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
            rotationY += mouseX;
            
            float x = distanceFromTarget * Mathf.Sin(Mathf.Deg2Rad * rotationY);
            float z = distanceFromTarget * Mathf.Cos(Mathf.Deg2Rad * rotationY);

            transform.position = new Vector3(Sphere.position.x + x, Sphere.position.y + perspectiveHeight, Sphere.position.z + z);
            transform.LookAt(Sphere);
        }
    }
}
