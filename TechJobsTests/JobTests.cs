using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job jobTest = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product Tester", jobTest.Name);
            Assert.AreEqual("ACME", jobTest.EmployerName);
            Assert.AreEqual("Desert", jobTest.EmployerLocation);
            Assert.AreEqual("Quality", jobTest.JobType);
            Assert.AreEqual("Persistence", jobTest.JobCoreCompetency);

        }
    }
}
