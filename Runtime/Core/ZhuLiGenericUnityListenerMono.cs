using UnityEngine;
using UnityEngine.Events;

public  class ZhuLiGenericUnityListenerMono<T,G> : MonoBehaviour where T : IZhuLiGenericCommand<G>
{
    public G m_lastReceived;
    public UnityEvent<T> m_onTheThingToDoInterface;
    public UnityEvent<G> m_onTheThingToDoValue;
    public void OnEnable()
    {
        ZhuLiGeneric<G>.AddListener(OnTheThingToDo);
    }
    public void OnDisable()
    {
        ZhuLiGeneric<G>.RemoveListener(OnTheThingToDo);
    }
    public void OnTheThingToDo(IZhuLiGenericCommand<G> theThingToDo)
    {
        DoTheThing(theThingToDo);
    }
    public void DoTheThing(IZhuLiGenericCommand<G> theThingToDo)
    {
        m_lastReceived = theThingToDo.GetValue();
        m_onTheThingToDoInterface.Invoke((T)theThingToDo);
        m_onTheThingToDoValue.Invoke(m_lastReceived);
        
    }
}
