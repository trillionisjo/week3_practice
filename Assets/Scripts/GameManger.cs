using UnityEngine;

public class GameManger : MonoBehaviour {
	private static GameManger s_instance;

	public static GameManger instance {
		get => s_instance;
		private set => s_instance = value;
	}

	public static void ShowCursor() {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public static void HideCursor() {
        Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
    }

	public static void ToggleCursor() {
		Cursor.lockState = Cursor.lockState == CursorLockMode.None ? CursorLockMode.Locked : CursorLockMode.None;
		Cursor.visible = !Cursor.visible;
	}

    public static UIConfigure uiConfigure {
		get;
		set;
	}

	public static CharacterData playerData {
		get;
		set;
	}

    private void Awake() {
		instance = this;
    }

    private void Start() {
		HideCursor();
    }

	public void ShowConfigureUI(bool show) {
		if (show == true) {
			uiConfigure.gameObject.SetActive(true);
			ShowCursor();
		} else {
			uiConfigure.gameObject.SetActive(false);
			HideCursor();
		}
	}

	public void CreateItem(ItemType type) {
		switch (type) {
		case ItemType.Ax:

			break;
		}
	}

}
