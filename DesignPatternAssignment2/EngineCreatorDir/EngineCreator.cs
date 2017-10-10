namespace DesignPatternAssignment2
{
    class EngineCreator : IEngineCreator
    {
        public virtual IDatabaseEngine FactoryMethod()
        {
            return new ConcreteDatabaseEngine();
        }
        public IDatabaseEngine CreateDatabaseEngine()
        {
            return FactoryMethod();
        }
    }
}
