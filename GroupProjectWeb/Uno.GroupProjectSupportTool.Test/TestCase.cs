using System;
using Uno.GroupProjectSupportTool.BAL;
using Uno.GroupProjectSupportTool.DAL;
using NUnit.Framework;


namespace Uno.GroupProjectSupportTool.Test
{

    [TestFixture]
    public class TestCase
    {

        [Test]
        public void OneThousand_G_E()
        {
            ProjectBAL obj = new ProjectBAL();
            Assert.AreEqual(950, obj.calculateDiscount(1000));
        }


        // Test Case#2: Sales Amount is Greater or Equal than 2000 : Verification  
        [Test]
        public void TwoThousand_G_E()
        {
            ProjectBAL obj = new ProjectBAL();
            Assert.AreEqual(1800, obj.calculateDiscount(2000));
        }
        // Test Case#3: Sales Amount is Greater or Equal than 5000 : Verification  
        [Test]
        public void FiveThousand_G_E()
        {
            ProjectBAL obj = new ProjectBAL();
            Assert.AreEqual(2500, obj.calculateDiscount(5000));
        }
        // Test Case#4: Sales Amount is 0 : Verification  
        [Test]
        public void ZeroAmount()
        {
            ProjectBAL obj = new ProjectBAL();
            try
            {
                obj.calculateDiscount(0);
            }
            catch (Exception e) { }
        }
        // Test Case#5: Sales Amount is below 1000 : Verification  
        [Test]
        public void OneThousand_Below()
        {
            ProjectBAL obj = new ProjectBAL();
            Assert.AreEqual(999, obj.calculateDiscount(999));
        }
        //__________Test for Actual Results__________  
        // Test Case#6: Sales Amount is not producing expected Result : Verification  
        [Test]
        public void OneThousand()
        {
            ProjectBAL obj = new ProjectBAL();
            Assert.AreNotEqual(930, obj.calculateDiscount(1000));
        }
        // Test Case#7: Sales Amount is not producing expected Result : Verification  
        [Test]
        public void TwoThousand()
        {
            ProjectBAL obj = new ProjectBAL();
            Assert.AreNotEqual(1900, obj.calculateDiscount(2000));
        }



        [Test]
        public void Add_New_Project()
        {
            // Arrange
            ProjectInsertInput insertProjectInput = new ProjectInsertInput();
            insertProjectInput.ManagerID = 1;

            ProjectBAL prjBal = new ProjectBAL();
            bool result = prjBal.Insert(insertProjectInput);


            // Assert
            Assert.AreNotEqual(true, result, "Project insert does not have all input");
        }









    }
}
