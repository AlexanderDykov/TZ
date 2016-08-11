using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour {

    Settings settings;
    [SerializeField]
    Text characterName;
    [SerializeField]
    Image characterIcon;

	// Use this for initialization
	void Awake () {
        settings = SettingsManager.Instance.LoadSettings();
        if (settings)
        {
            characterName.text = settings.characterName;
            characterIcon.sprite = settings.icon;
            gameObject.GetComponent<MeshRenderer>().material.color = settings.characterColor;
        }
    }
}
