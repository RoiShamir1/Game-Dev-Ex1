using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController2D>())
        {
            Destroy(gameObject);
            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("You reached the coin!");
        Time.timeScale = 0f;
    }
}
