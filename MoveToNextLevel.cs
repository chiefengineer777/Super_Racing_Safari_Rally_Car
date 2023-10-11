using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public int nextSceneLoad;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {

            //SceneManager.LoadScene(nextSceneLoad);
            if(SceneManager.GetActiveScene().buildIndex == 7)
            {
                Debug.Log("YOU WIN GAME");
            } else
            {
                // Move to next level
                SceneManager.LoadScene(nextSceneLoad);

                // Setting Int for Index
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }

            }

        }
    }
}
  