using System;
using System.Collections.Generic;
using System.Text;

namespace LooselyCoupled
{
    public class Computer
    {
        public IMemoryUnit RAM { get; set; }
        public IStorageDevice Disk { get; set; }
    }
    public interface IMemoryUnit
    {

    }
    public class RAM : IMemoryUnit
    {
        public int Capacity { get; set; }
        public string Vendor { get; set; }
    }
    public interface IStorageDevice
    {

    }
    public class HardDisk : IStorageDevice
    {
        public int RPM { get; set; }
    }
    public class SSD : IStorageDevice
    {

    }
}
