namespace Mission10_API.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }
    }
}
