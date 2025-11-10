#if UNITY_EDITOR
using NoisyBird.MonoExtension;
using UnityEditor;


namespace NoisyBird.MonoExtension.Editor
{
    [InitializeOnLoad]
    public static class SingletonRegistryMaker
    {
        static SingletonRegistryMaker()
        {
            SingletonRegistry.Instance.ForEach();
        }

        [MenuItem("Noisy Bird/MonoExtension/Singleton Registry Settings")]
        public static void MakeSingletonRegistry()
        {
            Selection.activeObject = SingletonRegistry.Instance;
            EditorGUIUtility.PingObject(SingletonRegistry.Instance);
        }
    }
    #endif
}
