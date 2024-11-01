using UnityEngine;

public class CharacterData : MonoBehaviour {
	public CharacterDataSO data;
	public int health;

    public CharacterData() {
        GameManger.playerData = this;
    }
}
