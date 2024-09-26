using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance {get; private set;}

    [SerializeField] private bool m_dontDestroyOnLoad;

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            if (m_dontDestroyOnLoad)
                DontDestroyOnLoad(gameObject);
        }
        else if (Instance != null && Instance != this)
        {
            Debug.LogError("There's more than one singleton " + gameObject.name + " of type " + GetType());
            Destroy(gameObject);
        }
    }
}