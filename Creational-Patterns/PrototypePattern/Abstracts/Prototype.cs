using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Abstracts
{
    abstract class Prototype
    {
        private string id;

        public Prototype(string _id)
        {
            id = _id;
        }

        public string ID
        {
            get
            {
                return id;
            }
        }

        public abstract Prototype Clone();
    }
}
