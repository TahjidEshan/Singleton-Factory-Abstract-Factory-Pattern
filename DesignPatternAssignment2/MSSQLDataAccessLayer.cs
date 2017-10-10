namespace DesignPatternAssignment2
{
    class MSSQLDataAccessLayer : DataAccessLayer<MSSQLDataAccessLayer>
    {
        public MSSQLDataAccessLayer GetLayer()
        {
            return GetInstance();
        }
        public new IEngineCreator GetCreator()
        {
            return new MSSQLCreator();
        }
    }
}