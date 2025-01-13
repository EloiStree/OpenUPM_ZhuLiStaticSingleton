public class ZhuLiIntCommand : IZhuLiCommand, IZhuLiGenericCommand<int>
{
    public int m_integerValue;
    public ZhuLiIntCommand(int integerValue)
    {
        m_integerValue = integerValue;
    }

    public int GetValue()
    {
        return m_integerValue;
    }
}
