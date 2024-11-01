using UnityEngine;

public class Hurting : MonoBehaviour {
	[SerializeField] private int damage;
    [SerializeField] private float damageDelay;
    [SerializeField] private string playerTag;

    private CharacterData playerData;
    private bool playerEntered;
    private float damageDelayCounter;

    private void Update() {
        if (playerEntered == false) {
            return;
        }

        damageDelayCounter += Time.deltaTime;
        if (damageDelayCounter < damageDelay) {
            return;
        }

        damageDelayCounter = 0f;
        playerData.health -= damage;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag(playerTag)) {
            playerEntered = true;
            playerData = other.GetComponent<CharacterData>();
            damageDelayCounter = 0f;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag(playerTag)) {
            playerEntered = false;
        }
    }
}
