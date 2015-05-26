using System;

public class SuggestItem
{
    public string term = "";
    public int distance = 0;
    public Int32 count = 0;

    public override bool Equals(object obj)
    {
        return Equals(term, ((SuggestItem)obj).term);
    }
     
    public override int GetHashCode()
    {
        return term.GetHashCode();
    }       
}