using System;

namespace DesignPatternAssignment2
{
    class MSSQL : ConcreteDatabaseEngine
    {
        public override void CreateView()
        {
            Console.WriteLine("MsSql CreateView");
        }
        public override void CreateCommand()
        {
            Console.WriteLine("MsSql CreateCommand");
        }
        public override void CreateTable()
        {
            Console.WriteLine("MsSql CreateTable");
        }
        public override void CreateAdapter()
        {
            Console.WriteLine("MsSql CreateAdapter");
        }
    }
}
