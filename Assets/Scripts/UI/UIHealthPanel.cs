using UnityEngine;
using UnityEngine.UI;

public class UIHealthPanel : MonoBehaviour {
	[SerializeField] private Image bar;
	[SerializeField] private Text value;

	private int health = -1;

    private void Update() {
        if (health != GameManger.playerData.health) {
            health = GameManger.playerData.health;
            bar.fillAmount = (float)health / GameManger.playerData.data.maxHealth;
            value.text = health.ToString();
        }
    }
}
