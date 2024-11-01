using UnityEngine;

public class UIConditions : MonoBehaviour {
	[SerializeField] private GameObject healthPanel;

    private void Awake() {
        Instantiate(healthPanel, transform);
    }
}
