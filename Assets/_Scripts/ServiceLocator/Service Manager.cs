using UnityEngine;

public class ServiceManager : MonoBehaviour
{
    [SerializeField] ButtonSoundManager soundManager;
    [SerializeField] ButtonClickCounter clickManager;

    void Awake()
    {
        RegisterService();
    }
    private void RegisterService()
    {
        ServiceLocator.RegisterService<ButtonSoundManager>(soundManager);
        ServiceLocator.RegisterService<ButtonClickCounter>(clickManager);
    }
    private void UnRegisterService()
    {
        ServiceLocator.Unregister<ButtonSoundManager>();
        ServiceLocator.Unregister<ButtonClickCounter>();
    }
    void OnDestroy()
    {
        UnRegisterService();
    }
}
