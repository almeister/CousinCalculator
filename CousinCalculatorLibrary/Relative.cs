using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousinCalculatorLibrary
{
    public class Relative
    {
        private Gender gender;
        private Relative father;
        private Relative mother;
        //private List<Relative> children = new List<Relative>();

        public Relative(Gender gender)
        {
            this.gender = gender;
        }

        public void addChild(Relative child)
        {
            if (this.gender == Gender.MALE)
            {
                child.setFather(this);
            }
            else if (this.gender == Gender.FEMALE)
            {
                child.setMother(this);
            }
        }

        Gender getGender()
        {
            return this.gender;
        }

        public void setFather(Relative father)
        {
            this.father = father;
        }

        public Relative getFather()
        {
            return this.father;
        }

        public void setMother(Relative mother)
        {
            this.mother = mother;
        }

        public Relative getMother()
        {
            return this.mother;
        }
    }
}
