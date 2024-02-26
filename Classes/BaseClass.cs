using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class BaseClass : IBase
    {
        public abstract void mid_value();
        public abstract void array_output();


        private bool way_to_fill {get; set;}
        public BaseClass(bool user_fill) {
            way_to_fill = user_fill;
        }

        protected abstract void FillByUser();
        protected abstract void RndmFill();
        protected void Fill() {
            if (way_to_fill) {
                FillByUser();
            } else {
                RndmFill();
            }
        }
    }
}