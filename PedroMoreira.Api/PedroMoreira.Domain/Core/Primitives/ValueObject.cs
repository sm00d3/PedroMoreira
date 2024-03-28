using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PedroMoreira.Domain.Core.Primitives
{
    public class ValueObject : IEquatable<ValueObject>
    {

        public static bool operator ==(ValueObject a, ValueObject b) {
            if(a is null && b is null) return true;
            if(a is null || b is null) return false;
            return a.Equals(b);
        }

        public static bool operator !=(ValueObject a, ValueObject b) => !(a == b);


        public bool Equals(ValueObject? other)
        {
            throw new NotImplementedException();
        }
    }
}
