using UnityEngine;

public class UIConfigure : MonoBehaviour {
    public UIConfigure() {
        GameManger.uiConfigure = this;
    }
}
