using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Alvo"))
        {
            CarController carController = FindObjectOfType<CarController>();

            if (carController != null)
            {
                carController.AddScore();
            }

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
