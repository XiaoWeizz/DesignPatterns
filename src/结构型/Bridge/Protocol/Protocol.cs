using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class Protocol
    {
        public ITransport transport {get; set;}
        public virtual void Connect()
        {
            transport?.Connect();
        }
        public virtual void Send(byte[] data)
        {
            transport?.Send(data);
        }
    }
}