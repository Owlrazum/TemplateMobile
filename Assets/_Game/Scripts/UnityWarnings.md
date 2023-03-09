UNT0021
All Unity messages should be protected. Unity messages do not need to be public for Unity to call them and are not meant to be called manually. Also, if a base class has a private message and a child class implements the same one, only the child one will be called without any notification or any way to call the base method.

UNT0022
Accessing the Transform should be done as few times as possible for performance reasons. Instead of setting position and rotation sequentially, you should use SetPositionAndRotation() method.