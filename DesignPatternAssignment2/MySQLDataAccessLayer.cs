using System;

namespace DesignPatternAssignment2
{
    class MySQLDataAccessLayer : DataAccessLayer<MySQLDataAccessLayer>
    {
        public MySQLDataAccessLayer GetLayer()
        {
            return GetInstance();
        }
        public new IEngineCreator GetCreator()
        {
            return new MySQLCreator();
        }
    }
}
