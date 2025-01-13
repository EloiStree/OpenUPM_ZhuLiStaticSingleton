public class ZhuLiGeneric<T> { 

    static TheThingToDo m_listeners;
    public delegate void TheThingToDo(IZhuLiGenericCommand<T> theThingToDo);
    public static void DoTheThing(IZhuLiGenericCommand<T> theThingToDo) {
        if (m_listeners != null)
            m_listeners(theThingToDo);
    }
    public static void AddListener(TheThingToDo listenerThatMayKnowHowToDoTheThing)
    {
        if (listenerThatMayKnowHowToDoTheThing != null)
            m_listeners += listenerThatMayKnowHowToDoTheThing;
    }
    public static void RemoveListener(TheThingToDo listenerThatMayKnowHowToDoTheThing)
    {
        if (listenerThatMayKnowHowToDoTheThing != null)
            m_listeners -= listenerThatMayKnowHowToDoTheThing;
    }
}
