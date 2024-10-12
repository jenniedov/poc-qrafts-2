using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; // Needed for PlayableDirector

public class playerState : MonoBehaviour
{
    public bool isPlayerPlaying = false;
    public GameObject animator;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // You can add logic to handle other behaviors in Update if necessary
    }

    // This method will be called when the play button is clicked or touched
    public void OnPlayButtonClicked()
    {
        Debug.Log("Play button clicked");
        if (animator != null)
        {
            if (!isPlayerPlaying)
            {
                animator.SetActive(true);
                isPlayerPlaying = true;
                Debug.Log("Video started playing.");
            }
        }
    }

    // This method will be called when the pause button is clicked or touched
    public void OnPauseButtonClicked()
    {
        Debug.Log("Pause button clicked");
        if (animator != null)
        {
            if (isPlayerPlaying)
            {
                isPlayerPlaying = false;
                animator.SetActive(false);
                Debug.Log("Video paused.");
            }
        }
    }
}
