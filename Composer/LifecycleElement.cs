using Composer;

public abstract class LifecycleElement : LightElementNode
{
    protected LifecycleElement(string tagName) : base(tagName) { }

    public void RenderWithLifecycle()
    {
        OnCreated();
        OnInserted();
        OnStylesApplied();
        OnClassListApplied();
        OnTextRendered();
        Console.WriteLine($"[{TagName}] відображено з життєвим циклом.");
    }

    protected virtual void OnCreated()
    {
        Console.WriteLine($"[{TagName}] Створено.");
    }

    protected virtual void OnInserted()
    {
        Console.WriteLine($"[{TagName}] Вставлено до DOM.");
    }

    protected virtual void OnStylesApplied()
    {
        Console.WriteLine($"[{TagName}] Застосовано стилі.");
    }

    protected virtual void OnClassListApplied()
    {
        Console.WriteLine($"[{TagName}] Застосовано список класів.");
    }

    protected virtual void OnTextRendered()
    {
        Console.WriteLine($"[{TagName}] Відображено текст.");
    }
}
