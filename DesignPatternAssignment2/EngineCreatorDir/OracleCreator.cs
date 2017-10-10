namespace DesignPatternAssignment2
{
    class OracleCreator : EngineCreator
    {
        public override IDatabaseEngine FactoryMethod()
        {
            return new Oracle();
        }
    }
}
