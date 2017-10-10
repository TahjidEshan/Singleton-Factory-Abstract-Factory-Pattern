namespace DesignPatternAssignment2
{
    class MSSQLCreator : EngineCreator
    {
        public override IDatabaseEngine FactoryMethod()
        {
            return new MSSQL();
        }
    }
}
