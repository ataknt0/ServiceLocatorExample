using System;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public static class ServiceLocator
{
    private static readonly Dictionary<Type, object> services = new();

    public static void RegisterService<T>(T service) where T : class
    {
        var type = typeof(T);

        if (services.ContainsKey(type))
        {
            Debug.LogWarning("${type} already registered");
            return;
        }
        services[type] = service;
    }
    public static bool TryRegisterService<T>(T service) where T : class
    {
        var type = typeof(T);

        if (services.ContainsKey(type))
        {
            return false;
        }
        services[type] = service;
        return true;
    }
    public static T GetService<T>() where T : class
    {
        var type = typeof(T);

        if (services.TryGetValue(type, out var service))
        {
            return service as T;
        }
        Debug.LogError("${type} is not registered in the Service Locator");
        return null;
    }
    public static bool TryGetService<T>(T service) where T : class
    {
        var type = typeof(T);

        if (services.TryGetValue(type, out var foundService))
        {
            service = foundService as T;
            return true;
        }
        service = null;
        return false;
    }
    public static bool IsRegister<T>() where T : class
    {
        return services.ContainsKey(typeof(T));
    }
    public static void Unregister<T>() where T : class
    {
        var type = typeof(T);

        services.Remove(type);
    }
}
