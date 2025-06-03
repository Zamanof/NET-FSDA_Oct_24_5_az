// Standard interfaces

using System.Collections;

class AgeComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        if (x is Student left && y is Student right)
        {
            var leftAge = DateTime.Now.Year - left.BirthDate.Year;
            var rightAge = DateTime.Now.Year - right.BirthDate.Year;
            if (leftAge < rightAge) return 1;
            else if (leftAge > rightAge) return -1;
            else return 0;
        }
        throw new Exception("Can not compare objects");
    }
}

