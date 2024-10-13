using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; // Needed for PlayableDirector



public class playerState : MonoBehaviour
{
    public bool isPlayerPlaying = false;
    public GameObject animatorGO;
    private PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        director = animatorGO.GetComponent<PlayableDirector>();
        director.Stop();
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
        if (director != null)
        {
            if (!isPlayerPlaying)
            {
                director.Play();
                isPlayerPlaying = true;
                Debug.Log("Video started playing.");
            }
        }
    }

    public void OnPauseButtonClicked()
    {
        Debug.Log("Pause button clicked");
        if (director != null)
        {
            if (isPlayerPlaying)
            {
                isPlayerPlaying = false;
                director.Pause();
                Debug.Log("Video paused.");
            }
        }
    }
}
