using System;

public static class PoolingDelegatesContainer
{
    public static Func<Poolable> FuncSpawn;
    public static Action<Poolable> EventDespawn;
}