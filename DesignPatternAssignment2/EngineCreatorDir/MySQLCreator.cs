namespace DesignPatternAssignment2
{
    class MySQLCreator : EngineCreator
    {
        public override IDatabaseEngine FactoryMethod()
        {
            return new MySQL();
        }
    }
}
