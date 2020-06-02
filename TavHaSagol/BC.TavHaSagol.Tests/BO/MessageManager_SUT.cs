using AM.Utils.PhoneConfirmation;
using BC.TavHaSagol.BO;
using BC.TavHaSagol.BO.Utils;
using BC.TavHaSagol.DAL.MySql.DataManagers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.TavHaSagol.Tests.BO
{
    [TestFixture]
    public class MessageManager_SUT
    {
        [SetUp]
        public void SetUp()
        {
           
        }

        [Test]
        public void PhoneConfirmationProcessStart()
        {
            IPhoneConfirmationManager dm = new PhoneConfirmationManager();
            IPhoneConfirmationValidator val = new SimpleValidator(new TimeSpan(0, 3, 0), 4, 3);
            int tId = Preferences.PhoneConfirmation.PhoneConfirmationTemplateId;
            IConfirmationMessageManager mm = new MdsConfirmationMessageSender(tId);

            PhoneConfirmation sutPhoneConfirmation = new PhoneConfirmation(dm, mm, val);
            try
            {
                string id = sutPhoneConfirmation.StartValidationAsync("972547757671").Result;

            }
            catch(Exception ex)
            {

            }
        }

        [Test]
        public void PhoneConfirmationProcessFinish()
        {
            IPhoneConfirmationManager dm = new PhoneConfirmationManager();
            IPhoneConfirmationValidator val = new SimpleValidator(new TimeSpan(0, 3, 0), 4, 3);
            int tId = Preferences.PhoneConfirmation.PhoneConfirmationTemplateId;
            IConfirmationMessageManager mm = new MdsConfirmationMessageSender(tId);

            PhoneConfirmation sutPhoneConfirmation = new PhoneConfirmation(dm, mm, val);
            try
            {
                var res = sutPhoneConfirmation.FinishValidationAsync("a268e685-2cf0-4c64-bf8e-aca75d90069c", "4554").Result;
                Assert.IsFalse(res);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
