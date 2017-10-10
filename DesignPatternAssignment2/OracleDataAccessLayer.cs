namespace DesignPatternAssignment2
{
    class OracleDataAccessLayer : DataAccessLayer<OracleDataAccessLayer>
    {
        public OracleDataAccessLayer GetLayer()
        {
            return GetInstance();
        }
        public new IEngineCreator GetCreator()
        {
            return new OracleCreator();
        }
    }
}