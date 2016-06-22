using UnityEngine;
using System.Collections;

public class SplashScreenManager : MonoBehaviour
{

    public float duration = 3f;
    public AudioClip sound;
    // Use this for initialization
    void Start()
    {
        AudioSource.PlayClipAtPoint(sound, transform.position);
        FindObjectOfType<LevelManager>().Invoke("LoadNextLevel", duration);
    }
}
