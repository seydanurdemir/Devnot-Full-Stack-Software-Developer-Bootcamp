using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractVSInterface
{
    public abstract class DataSource
    {
        public abstract List<string> ReadData();
        
        //public abstract void WriteData();
        public void CopyResource()
        {
            Console.WriteLine("Resource copied successfully.");
        }
        
    }
    public interface IDataWritable // Interface > Loosely Coupling
    {
        public void WriteData();
    }
    public class XMLDataSource : DataSource
    {
        public override List<string> ReadData()
        {
            return new List<string>();
        }

        //public override void WriteData()
        //{
        //    
        //}
    }
    public class ExcelDataSource : DataSource, IDataWritable
    {
        public override List<string> ReadData()
        {
            return new List<string>();
        }

        public void WriteData()
        {
            throw new NotImplementedException();
        }

        //public override void WriteData()
        //{

        //}
    }
    public class DbDataSource : DataSource, IDataWritable
    {
        public override List<string> ReadData()
        {
            return new List<string>();
        }

        public void WriteData()
        {
            throw new NotImplementedException();
        }

        //public override void WriteData()
        //{

        //}
    }
}
