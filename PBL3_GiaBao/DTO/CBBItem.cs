using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_GiaBao.DTO
{
    class CBBItem
    {
        object value;
        string text;

        public object Value { get => value; set => this.value = value; }
        public string Text { get => text; set => text = value; }

        public override string ToString()
        {
            return Text;
        }
    }
}
