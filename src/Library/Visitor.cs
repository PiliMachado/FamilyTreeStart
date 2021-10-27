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

    protected int ContentBuilder { get; set ; } 

    public abstract void Visit(Node nodo);
    public abstract void Visit (Persona person);

}