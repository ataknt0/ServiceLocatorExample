using UnityEngine;
public class ServiceManager : MonoBehaviour
{
    // These references must be assigned via the Inspector.
    // They represent the concrete instances of the services to be registered.
    [SerializeField] private ButtonSoundManager soundManager;
    [SerializeField] private ButtonClickCounter clickManager;
    private void Awake()
    {
        RegisterService();
    }

    // Registers the required services into the ServiceLocator.
    private void RegisterService()
    {
        ServiceLocator.RegisterService<ButtonSoundManager>(soundManager);
        ServiceLocator.RegisterService<ButtonClickCounter>(clickManager);
    }

    // Unregisters the services from the ServiceLocator to avoid memory leaks or dangling references.
    private void UnRegisterService()
    {
        ServiceLocator.Unregister<ButtonSoundManager>();
        ServiceLocator.Unregister<ButtonClickCounter>();
    }

    // Called automatically by Unity when this GameObject is being destroyed.
    // Ensures the service container is cleaned up properly.
    private void OnDestroy()
    {
        UnRegisterService();
    }
}
