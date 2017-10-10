using System;

namespace DesignPatternAssignment2
{
    class MySQL : ConcreteDatabaseEngine
    {
        public override void CreateView()
        {
            Console.WriteLine("MySql CreateView");
        }
        public override void CreateCommand()
        {
            Console.WriteLine("MySql CreateCommand");
        }
        public override void CreateTable()
        {
            Console.WriteLine("MySql CreateTable");
        }
        public override void CreateAdapter()
        {
            Console.WriteLine("MySql CreateAdapter");
        }
    }
}
