namespace KANIYONIKA.ECSPrefabHelper
{
    using Unity.Entities;

    public struct ECSPrefabTag : ITagComponentData { }

    [System.Serializable]
    public struct ECSPrefabData : IComponentData
    {
    }

    [System.Serializable]
    public struct ECSPrefabBuffer : IBufferElementData
    {
        public Entity Prefab;
    }

    /// <summary>
    /// 共通のタグ用インターフェース。タグ（データなしのマーカーコンポーネント）であることを明示するために使用します。
    /// 制約付きジェネリックなどで「タグであるコンポーネント」だけを対象に処理したいときに便利です。
    /// </summary>
    public interface ITagComponentData : IComponentData { }
}
