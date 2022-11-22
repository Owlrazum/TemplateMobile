using UnityEngine;
using UnityEngine.Pool;

public class Pooler
{
    private ObjectPool<Poolable> _pool;
    public Pooler(Poolable poolable)
    {
        // _pool = new ObjectPool<Poolable>(

        // );
    }

    public Poolable Spawn()
    {
        return _pool.Get();
    }

    public void Despawn(Poolable poolable)
    {
        _pool.Release(poolable);
    }
}
