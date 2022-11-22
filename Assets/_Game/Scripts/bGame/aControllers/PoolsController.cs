using UnityEngine;
using UnityEngine.Pool;

public class PoolsController : MonoBehaviour
{
    [SerializeField]
    private Poolable _prefab;

    private ObjectPool<Poolable> _pool;

    private void Awake()
    {
        _pool = new ObjectPool<Poolable>(
            Create,
            null,
            null,
            null,
            false,
            10,
            10000
        );

        PoolingDelegatesContainer.FuncSpawn += Spawn;
        PoolingDelegatesContainer.EventDespawn += Despawn;
    }

    private void OnDestroy()
    {
        PoolingDelegatesContainer.FuncSpawn -= Spawn;
        PoolingDelegatesContainer.EventDespawn -= Despawn;
    }

    private Poolable Create()
    {
        GameObject gb = Instantiate(_prefab.gameObject);
        return gb.GetComponent<Poolable>();
    }

    private Poolable Spawn()
    {
        return _pool.Get();
    }

    private void Despawn(Poolable bs)
    {
        _pool.Release(bs);
    }
}