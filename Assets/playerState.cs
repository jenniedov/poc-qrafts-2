using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; // Needed for PlayableDirector

public class playerState : MonoBehaviour
{
    public bool isPlayerPlaying = false;
    public Record3DPlayback record3DPlayback;



    // Start is called before the first frame update
    void Start()
    {
        if (record3DPlayback != null)
        {
            isPlayerPlaying = false;
            record3DPlayback.Pause();
        }
    }

    // Update is called once per frame
    void Update()
    {

        // You can add logic to handle other behaviors in Update if necessary
    }

    // This method will be called when the play button is clicked or touched
    public void OnPlayButtonClicked()
    {
        if (record3DPlayback != null)
        {
            if (!isPlayerPlaying)
            {
                record3DPlayback.Play();
                isPlayerPlaying = true;
            }
        }
    }

    // This method will be called when the pause button is clicked or touched
    public void OnPauseButtonClicked()
    {
        if (record3DPlayback != null)
        {
            if (isPlayerPlaying)
            {
                record3DPlayback.Pause();
                isPlayerPlaying = false;
            }
        }
    }
}
