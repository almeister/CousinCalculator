using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CousinCalculatorLibrary;

namespace CousinCalculatorTests
{
    [TestClass]
    public class RelativeTests
    {
        private CousinCalculator calculator;
        private Relative grandFather;
        private Relative grandMother;
        private Relative father;
        private Relative mother;
        private Relative uncle;
        private Relative aunt;

        [TestInitialize()]
        public void init()
        {
            calculator = new CousinCalculator();

            grandFather = new Relative(Gender.MALE);
            grandMother = new Relative(Gender.FEMALE);
            father = new Relative(Gender.MALE);
            mother = new Relative(Gender.FEMALE);
            uncle = new Relative(Gender.MALE);
            aunt = new Relative(Gender.FEMALE);
        }

        [TestMethod]
        public void siblingsRelationship()
        {
            Relative daughter = new Relative(Gender.FEMALE);
            Relative son = new Relative(Gender.MALE);
            father.addChild(daughter);
            father.addChild(son);

            Assert.AreEqual(Relationship.NOT_COUSINS, calculator.findRelationship(daughter, son));
        }

        [TestMethod]
        public void firstCousinsRelationship()
        {
            Relative daughter = new Relative(Gender.FEMALE);
            Relative cousin = new Relative(Gender.MALE);

            grandFather.addChild(father);
            grandFather.addChild(aunt);
            father.addChild(daughter);
            aunt.addChild(cousin);

            Assert.AreEqual(Relationship.COUSINS, calculator.findRelationship(daughter, cousin));
        }
    }
}
