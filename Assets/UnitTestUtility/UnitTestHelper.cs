using UnityEngine;

public static class UnitTestHelper
{
    public static GameObject InstantiateFromResource(string prefabName)
    {
        return Object.Instantiate(Resources.Load<GameObject>(prefabName));
    }

    public static void CleanUp()
    {
        var allGameObject = Object.FindObjectsByType<GameObject>(FindObjectsSortMode.None);
        foreach (var gameObject in allGameObject)
        {
            Object.Destroy(gameObject);
        }
    }
}
