using System;
using UnityEngine;
using UnityEngine.UI;

public class CreateAxButton : MonoBehaviour {
	private Button button;

    private void Awake() {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked() {
        var prefab = Resources.Load<GameObject>("Prefabs/Ax");
        var obj = Instantiate(prefab, Vector3.up, Quaternion.identity);
    }
}
