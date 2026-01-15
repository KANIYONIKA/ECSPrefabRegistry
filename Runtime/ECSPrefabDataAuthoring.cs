namespace KANIYONIKA.ECSPrefabHelper
{
    using UnityEngine;
    using Unity.Entities;

    public class ECSPrefabTagAuthoring : MonoBehaviour
    {
        public GameObject[] PrefabEntries;

        class Baker : Unity.Entities.Baker<ECSPrefabTagAuthoring>
        {
            public override void Bake(ECSPrefabTagAuthoring authoring)
            {
                var e = GetEntity(TransformUsageFlags.None);
                AddComponent(e, new ECSPrefabTag());
                AddComponent(e, new ECSPrefabData() { });

                var buffer = AddBuffer<ECSPrefabBuffer>(e);

                for (int i = 0; i < authoring.PrefabEntries.Length; i++)
                {
                    var prefabEntity = GetEntity(authoring.PrefabEntries[i], TransformUsageFlags.Renderable | TransformUsageFlags.Dynamic);
                    buffer.Add(new ECSPrefabBuffer
                    {
                        Prefab = prefabEntity
                    });
                }
            }
        }
    }
}
