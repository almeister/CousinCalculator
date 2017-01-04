using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousinCalculatorLibrary
{
    public class CousinCalculator
    {
        public Relationship findRelationship(Relative firstReli, Relative secondReli)
        {
            Relative father = firstReli.getFather();
            Relative mother = firstReli.getMother();

            if (father == null && mother == null)
            {
                throw new InsufficientFamilyHistoryException("At least one parent is required per child.");
            }

            if (father != null)
            {
                if (father.getFather() == null && father.getMother() == null)
                {
                    throw new InsufficientFamilyHistoryException("You must specify both Grandparents on the Father's side.");
                }
            }
            if (mother != null)
            {
                if (mother.getFather() == null && mother.getMother() == null)
                {
                    throw new InsufficientFamilyHistoryException("You must specify both Grandparents on the Mother's side.");
                }
            }

            //throw new InsufficientFamilyHistoryException("You must specify at least one parent.");

            return Relationship.NOT_COUSINS;
        }
    }
}
