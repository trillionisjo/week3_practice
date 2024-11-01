using UnityEngine;

public enum ItemType {
	None = 0,
	Ax = 1
}

[CreateAssetMenu(fileName = "New ItemData")]
public class ItemDataSO : ScriptableObject {
	public ItemType type;
	
	public void CreateGmaeObject(Transform position) {
		switch (type) {
		case ItemType.Ax:
			var prefab = Resources.Load<GameObject>("Ax");
			Instantiate(prefab, position.position, Quaternion.identity);
			break;
		}
	}
}
