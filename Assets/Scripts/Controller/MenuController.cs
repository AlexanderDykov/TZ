using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

    public void AddSettingsToLevel(Settings settings)
    {
        SettingsManager.Instance.SaveSettings(settings);
    }

    public void LoadLevel(int levelNumber)
    {
        SceneManager.LoadSceneAsync(levelNumber);
    }
}
