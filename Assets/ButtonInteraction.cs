using UnityEngine;

public class ButtonInteraction : MonoBehaviour
{
    public playerState playerState; // Reference to the PlayerState script

    private void OnTriggerEnter(Collider other)
    {
        // Assuming the player's hand has a layer "Hand"
        if (other.gameObject.layer == LayerMask.NameToLayer("Hand"))
        {
            Debug.Log("Hand has touched a button");
            if (gameObject.name == "play_button")
            {
                playerState.OnPlayButtonClicked();
                Debug.Log("Player Playing: " + playerState.isPlayerPlaying);
            }
            else if (gameObject.name == "pause_button")
            {
                playerState.OnPauseButtonClicked();
                Debug.Log("Player Playing: " + playerState.isPlayerPlaying);
            }
        }
    }

}
