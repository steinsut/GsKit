using UnityEngine;

namespace GsKit.Pooling
{
    [CreateAssetMenu(fileName = "Pool Resource", menuName = "GsKit/Pooling/Pool Resource")]
    [System.Serializable]
    public class PoolResource : Resources.AbstractResource
    {
        [Tooltip("The prefab that will be in this pool.")]
        [SerializeField]
        private PrefabResource _prefabResource;

        [Min(1)]
        [Tooltip("The minimum number of objects that will be in this pool at any time.")]
        [SerializeField]
        private int _minimumObjects;

        [Tooltip(
            "Check this if you want to limit the number of objects that will be in this pool to the maximum object count.")]
        [SerializeField]
        private bool _limitObjectCount;

        [Min(1)]
        [Tooltip("The maximum number of objects that will be in this pool at any time.")]
        [SerializeField]
        private int _maximumObjects;

        [Tooltip("Check this if the pool should be populated on load. (When PoolManager is instantiated.)")]
        [SerializeField]
        private bool _populateOnLoad;

        [Tooltip("Check this if chached components on the object should be reset on return. (If the component implements IResettable)")]
        [SerializeField]
        private bool _resetOnReturn;

        [Tooltip("Don't destroy pool objects when a scene change happens.")]
        [SerializeField]
        private bool _preserveOnSceneChange;

        [SerializeField]
        [HideInInspector]
        private int _componentMask;

        public PrefabResource PrefabResource => _prefabResource;

        public int MinimumObjects => _minimumObjects;
        public bool LimitObjectCount => _limitObjectCount;
        public int MaximumObjects => _maximumObjects;
        public bool ResetOnReturn => _resetOnReturn;

        public bool PreserveOnSceneChange => _preserveOnSceneChange;
        public bool PopulateOnLoad => _populateOnLoad;

        public int ComponentMask => _componentMask;
    }
}