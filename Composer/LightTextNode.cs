using Composer;

public class LightTextNode : LightNode
{
    public string Text { get; set; }

    public LightTextNode(string text)
    {
        Text = text;
    }

    public override string InnerHTML()
    {
        return Text;
    }

    public override string OuterHTML()
    {
        return Text;
    }

    public override void TriggerEvent(string eventType) { }

    public override void Accept(ILightNodeVisitor visitor)
    {
        visitor.VisitText(this);
    }
}
