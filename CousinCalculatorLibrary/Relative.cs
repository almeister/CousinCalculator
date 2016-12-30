using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousinCalculatorLibrary
{
    public class Relative
    {
        private Gender gender = Gender.NONE;
        private List<Relative> children = new List<Relative>();

        public Relative(Gender gender)
        {
            this.gender = gender;
        }

        public Relative()
        {
            this.gender = Gender.NONE;
        }

        public void addChild(Relative relative)
        {
            children.Add(relative);
        }
    }
}
