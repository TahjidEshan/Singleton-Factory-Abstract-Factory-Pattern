using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngineCreator Creator = new EngineCreator();
            Console.WriteLine("Press 1 for MySql\nPress 2 for MsSql\nPress 3 for Oracle");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    MySQLDataAccessLayer MySqlLayer = DataAccessLayer<MySQLDataAccessLayer>.GetInstance();
                    Creator = MySqlLayer.GetCreator();
                    break;
                case 2:
                    MSSQLDataAccessLayer MsSqlLayer = DataAccessLayer<MSSQLDataAccessLayer>.GetInstance();
                    Creator = MsSqlLayer.GetCreator();
                    break;
                case 3:
                    OracleDataAccessLayer OracleLayer = DataAccessLayer<OracleDataAccessLayer>.GetInstance();
                    Creator = OracleLayer.GetCreator();
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            IDatabaseEngine DB = Creator.CreateDatabaseEngine();
            DB.CreateAdapter();
            DB.CreateCommand();
            DB.CreateTable();
            DB.CreateView();
            Console.ReadLine();
        }
    }
}
