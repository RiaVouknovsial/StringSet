class StringSet
{
    public string Value { get; set; }

    public static StringSet operator +(StringSet s1, StringSet s2)
    {
        return new StringSet { Value = s1.Value + s2.Value };
    }

    public static StringSet operator &(StringSet s1, StringSet s2)
    {
        string[] s1Values = s1.Value.Split(", ");
        string[] s2Values = s2.Value.Split(", ");

        string intersection = string.Join(", ", s1Values.Intersect(s2Values));

        return new StringSet { Value = intersection };
    }
}