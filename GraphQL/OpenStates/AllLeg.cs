public class Node3
{
    public string name { get; set; }
    public string classification { get; set; }
    public string id { get; set; }
}

public class Edge2
{
    public Node3 node { get; set; }
}

public class Children
{
    public List<Edge2> edges { get; set; }
}

public class Node2
{
    public string name { get; set; }
    public string classification { get; set; }
    public Children children { get; set; }
}

public class Edge
{
    public Node2 node { get; set; }
}

public class Legislature
{
    public List<Edge> edges { get; set; }
}

public class Node
{
    public string name { get; set; }
    public Legislature legislature { get; set; }
}

public class RootObject
{
    public Node node { get; set; }
}