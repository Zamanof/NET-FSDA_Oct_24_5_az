// delgates
// delegate return_datatype delegate_name([parameter list])
internal class Human
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name} - > {Age}";
    }
}