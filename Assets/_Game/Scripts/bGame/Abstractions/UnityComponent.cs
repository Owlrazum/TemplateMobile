using UnityEngine;

/// <summary>
/// It is a way to restrict interfaces only to MonoBehaviours.
/// In addition, I have decided to not include I to the name of the interface deliberately.
/// The reasons can be found here: https://stackoverflow.com/questions/5816951/prefixing-interfaces-with-i
/// It is called UnityComponent to not collide with build-in class Component
/// </summary>
public interface UnityComponent
{
    Transform transform { get; }
    GameObject gameObject { get; }
}