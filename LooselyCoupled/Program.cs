using System;

namespace LooselyCoupled
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Disk = new HardDisk();
            computer.Disk = new SSD();
        }
    }
}
