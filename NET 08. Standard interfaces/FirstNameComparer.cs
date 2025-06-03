// Standard interfaces

using System.Collections;

class FirstNameComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if(x is Student left && y is Student right)
        {
            return string.Compare(left.FirstName, right.FirstName);
        }
        throw new Exception("Can not compare objects");
    }
}

