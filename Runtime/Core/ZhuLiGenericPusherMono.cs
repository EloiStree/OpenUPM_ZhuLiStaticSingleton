using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class ZhuLiGenericPusherMono<T,G> : MonoBehaviour where T: IZhuLiGenericCommand<G>, IZhuLiCommand
{
    public G m_valueToPushFromInspector;


    public void PushIn(G value)
    {
        T command = GetHolder(value);
        PushIn(command);
    }
    public abstract T GetHolder(G value);
    public void PushIn(T value)
    {
        if (value!=null)
            m_valueToPushFromInspector = value.GetValue();
        ZhuLiGeneric<G>.DoTheThing(value);
    }
}

public class ZhuLiValueCommand<G>: IZhuLiCommand, IZhuLiGenericCommand<G>
{
    public G m_value;
    public ZhuLiValueCommand(G value)
    {
        m_value = value;
    }

    public G GetValue()
    {
        return m_value;
    }
}
