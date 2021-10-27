using Library;
public abstract class Visitor
{
    public string Content
    {
        get
        {
            return this.ContentBuilder.ToString();
        }
    }

    protected int ContentBuilder { get; } 

    public abstract void Visit(Node nodo);


}