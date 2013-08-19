using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using CalumGayleWeb.Models;
using NUnit.Framework;

namespace CalumAndGayleTests
{
    [TestFixture]
    public class ModelTestFixture
    {
        [Test]
        public void RSVP_Model_Name_Required()
        {
            //Assign
            var rsvp = new Rsvp();
            var context = new ValidationContext(rsvp);
            var validationResults = new List<ValidationResult>();

            //Act
            var isValid = Validator.TryValidateObject(rsvp, context, validationResults, true);

            //Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(validationResults.Any(name => name.ErrorMessage == "The Name field is required."));
        }

        [Test]
        public void RSVP_Model_Email_Required()
        {
            //Assign
            var rsvp = new Rsvp();
            var context = new ValidationContext(rsvp);
            var validationResults = new List<ValidationResult>();

            //Act
            var isValid = Validator.TryValidateObject(rsvp, context, validationResults, true);

            //Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(validationResults.Any(name => name.ErrorMessage == "The Email field is required."));
        }

        [Test]
        public void RSVP_Model_Email_Must_Be_Format()
        {
            //Assign
            var rsvp = new Rsvp
                {
                    Email = "TEST"
                };
            var context = new ValidationContext(rsvp);
            var validationResults = new List<ValidationResult>();

            //Act
            var isValid = Validator.TryValidateObject(rsvp, context, validationResults, true);

            //Assert
            Assert.IsFalse(isValid);
            Assert.IsTrue(validationResults.Any(name => name.ErrorMessage == "The Email field is not a valid e-mail address."));
        }
    }
}
