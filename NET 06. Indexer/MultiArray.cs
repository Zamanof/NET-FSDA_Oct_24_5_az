class MultiArray
{
    int[,] array;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        array = new int[Rows, Columns];
    }

    // multidimension indexer
    public int this[int row, int column]
    {
        get => array[row, column];
        set => array[row, column] = value;
    }
}
