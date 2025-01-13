using UnityEngine;

public abstract class ZhuLiGenericListenerMono<T> : MonoBehaviour where T : IZhuLiGenericCommand<T>
{
    public void OnEnable()
    {
        ZhuLiGeneric<T>.AddListener(OnTheThingToDo);
    }
    public void OnDisable()
    {
        ZhuLiGeneric<T>.RemoveListener(OnTheThingToDo);
    }
    public void OnTheThingToDo(IZhuLiGenericCommand<T> theThingToDo)
    {
        DoTheThing(theThingToDo);
    }
    public abstract void DoTheThing(IZhuLiGenericCommand<T> theThingToDo);
}
