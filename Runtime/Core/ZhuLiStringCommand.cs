public class ZhuLiStringCommand : IZhuLiCommand , IZhuLiGenericCommand<string>
{
    public string m_string;
    public ZhuLiStringCommand(string str)
    {
        m_string = str;
    }

    public string GetValue()
    {
        return m_string;
    }
}
