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

            grandFather.addChild(mother);
            grandMother.addChild(mother);
            grandFather.addChild(uncle);
            grandMother.addChild(uncle);
        }

        [TestMethod]
        public void siblingsRelationship()
        {
            Relative daughter = new Relative(Gender.FEMALE);
            Relative son = new Relative(Gender.MALE);
            mother.addChild(daughter);
            mother.addChild(son);

            Assert.AreEqual(Relationship.NOT_COUSINS, calculator.findRelationship(daughter, son));
        }

        [TestMethod]
        [ExpectedException(typeof(InsufficientFamilyHistoryException), "At least one parent is required per child.")]
        public void atLeastOneParentRequired()
        {
            Relative orphan1 = new Relative(Gender.MALE);
            Relative orphan2 = new Relative(Gender.MALE);

            calculator.findRelationship(orphan1, orphan2);
        }

        [TestMethod]
        [ExpectedException(typeof(InsufficientFamilyHistoryException), "")]
        public void noGrandparentsOnFirstRelative()
        {
            calculator.findRelationship(mother, uncle);
        }

        //[TestMethod]
        //public void firstCousinsThroughSiblingParents()
        //{
        //    Relative daughter = new Relative(Gender.FEMALE);
        //    Relative cousin = new Relative(Gender.MALE);

        //    father.addChild(daughter);
        //    aunt.addChild(cousin);

        //    Assert.AreEqual(Relationship.COUSINS, calculator.findRelationship(daughter, cousin));
        //}

        //[TestMethod]
        //public void firstCousinsThroughInLawParents()
        //{
        //    Relative daughter = new Relative(Gender.FEMALE);
        //    Relative cousin = new Relative(Gender.MALE);

        //    father.addChild(daughter);
        //    aunt.addChild(cousin);

        //    Assert.AreEqual(Relationship.COUSINS, calculator.findRelationship(daughter, cousin));
        //}
    }
}
