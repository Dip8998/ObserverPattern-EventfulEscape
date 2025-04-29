using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] private int keysRequiredToTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<PlayerView>() != null && keysRequiredToTrigger == GameService.Instance.GetPlayerController().KeysEquipped)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(SoundType.SpookyGiggle);
            this.enabled = false;
        }
    }
}