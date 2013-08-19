﻿using CalumAndGale.Controllers;
using CalumAndGale.Models;
using NUnit.Framework;

namespace CalumAndGaleTests
{
    [TestFixture]
    public class HomeControllerTestFixture
    {
        [Test]
        public void Can_Create_HomeControlder()
        {
            var controler = new CalumAndGaleController();

            Assert.NotNull(controler);
        }

        [Test]
        public void Submit_Empty_RSVP_Index_View()
        {
            var controler = new CalumAndGaleController();

            var result = controler.Submitted(new Rsvp());

            Assert.AreEqual("Index", result.ViewName);
        }

        [Test]
        public void Submit_RSVP_No_Name_Index_View()
        {
            var controler = new CalumAndGaleController();

            var result = controler.Submitted(new Rsvp { Email = "Test@test.com" });

            Assert.AreEqual("Index", result.ViewName);
        }

        [Test]
        public void Submit_RSVP_No_Email_Index_View()
        {
            var controler = new CalumAndGaleController();

            var result = controler.Submitted(new Rsvp { Name = "Name" });

            Assert.AreEqual("Index", result.ViewName);
        }

        [Test]
        public void Submit_RSVP_With_Name_And_Email_Submitted_View()
        {
            var controler = new CalumAndGaleController();

            var result = controler.Submitted(new Rsvp { Name = "Name", Email = "Test@test.com" });

            Assert.AreEqual("Submitted", result.ViewName);
        }
    }
}
