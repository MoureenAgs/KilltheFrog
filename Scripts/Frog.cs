using UnityEngine;

public class Frog : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameManager.instance.AddScore();
        Destroy(gameObject);
    }
}
