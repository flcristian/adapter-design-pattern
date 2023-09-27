using adapter_pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Target target = new Adapter();
        target.Request();
    }
}