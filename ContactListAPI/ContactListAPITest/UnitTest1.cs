using ContactListAPI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ContactListAPITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindMichael()
        {
            string name = "Michael";
            ContactRepository cr = new ContactRepository();
            Assert.IsNotNull(cr.FindByName(name));
        }

        [TestMethod]
        public void DeleteSomebody()
        {
            int id = 1;
            ContactRepository cr = new ContactRepository();
            cr.DeleteById(id);
            Assert.AreEqual(1, cr.GetList().Count);

        }
    }
}
