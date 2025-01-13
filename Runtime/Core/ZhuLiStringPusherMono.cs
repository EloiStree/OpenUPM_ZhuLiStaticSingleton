public class ZhuLiStringPusherMono : ZhuLiGenericPusherMono<ZhuLiValueCommand<string>, string>
{
    public ZhuLiStringPusherMono()
    {
    }

    public override ZhuLiValueCommand<string> GetHolder(string value)
    {
        return new ZhuLiValueCommand<string>(value);
    }

}
