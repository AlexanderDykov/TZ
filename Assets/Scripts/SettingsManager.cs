using UnityEngine;
using System.Collections;

public class SettingsManager : MonoBehaviour {

    static Settings settings;
    private static SettingsManager _instance;
    public static SettingsManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<SettingsManager>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            if (this != _instance)
                Destroy(this.gameObject);
        }
    }

    public void SaveSettings(Settings newSettings)
    {
        settings = newSettings;
    }

    public Settings LoadSettings()
    {
        return settings;
    }
}
