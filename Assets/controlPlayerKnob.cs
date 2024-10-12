using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayerKnob : MonoBehaviour
{
    public playerState playerState;
    public Transform playerKnobTransform;
    public float xStartPosition = -0.155f;
    public float xEndPosition = 0.665f;
    public float speedXmove = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Set transform of x to be "-0.155", but keep y and z the same
        playerKnobTransform.localPosition = new Vector3(-0.155f, playerKnobTransform.localPosition.y, playerKnobTransform.localPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerState.isPlayerPlaying)
        {
            // while the knob is not at the end position, move it towards the end position
            if (playerKnobTransform.localPosition.x < xEndPosition)
            {
                playerKnobTransform.localPosition += new Vector3(speedXmove * Time.deltaTime, 0, 0);
            }
            // while the knob is not at the start position, move it towards the start position
            else if (playerKnobTransform.localPosition.x > xStartPosition)
            {
                playerKnobTransform.localPosition = new Vector3(xStartPosition, playerKnobTransform.localPosition.y, playerKnobTransform.localPosition.z);
            }
        }
    }
}
