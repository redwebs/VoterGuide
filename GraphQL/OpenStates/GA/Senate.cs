public class Organization
{
    public string name { get; set; }
}

public class Party
{
    public Organization organization { get; set; }
}

public class Link
{
    public string url { get; set; }
}

public class Source
{
    public string url { get; set; }
}

public class Post
{
    public string label { get; set; }
}

public class Chamber
{
    public Post post { get; set; }
}

public class ContactDetail
{
    public string type { get; set; }
    public string value { get; set; }
    public string note { get; set; }
    public string label { get; set; }
}

public class RootObject
{
    public string id { get; set; }
    public string name { get; set; }
    public string familyName { get; set; }
    public string givenName { get; set; }
    public string image { get; set; }
    public List<Party> party { get; set; }
    public List<Link> links { get; set; }
    public List<Source> sources { get; set; }
    public List<Chamber> chamber { get; set; }
    public List<ContactDetail> contactDetails { get; set; }
}