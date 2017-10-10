namespace DesignPatternAssignment2
{
    public interface IEngineCreator
    {
        IDatabaseEngine FactoryMethod();
        IDatabaseEngine CreateDatabaseEngine();
    }
}
