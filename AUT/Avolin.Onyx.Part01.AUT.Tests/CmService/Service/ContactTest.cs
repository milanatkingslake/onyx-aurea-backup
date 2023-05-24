using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Contact" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Contact.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ContactTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ContactNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public ContactTest() : base(publicType: typeof(Common), classNameWithNamespace: ContactNonPublicTypeName)
        { }

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        private Type _contactInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ContactNonPublicTypeName = "CmService.Service.Contact";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _contactInstance;
        private object _contactInstanceFixture;

        #region General Initializer : Class (Contact) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Contact" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _contactInstanceFixture = this.CreateNonPublicType(ContactNonPublicTypeName);
            _contactInstance = _contactInstanceFixture;
            CurrentInstance = _contactInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Contact) Initializer

        #region Methods

        private const string MethodGetContactByOwner = "GetContactByOwner";
        private const string MethodGetInternalContactByOwner = "GetInternalContactByOwner";
        private const string MethodGetExternalContactByOwner = "GetExternalContactByOwner";
        private const string MethodGetContactTypeByCategoryId = "GetContactTypeByCategoryId";
        private const string MethodGetInternalContactUserList = "GetInternalContactUserList";
        private const string MethodAddInternalContact = "AddInternalContact";
        private const string MethodAddExternalContact = "AddExternalContact";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Contact)

        #region General Initializer : Class (Contact) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Contact" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetContactByOwner, 0)]
        [TestCase(MethodGetInternalContactByOwner, 0)]
        [TestCase(MethodGetExternalContactByOwner, 0)]
        [TestCase(MethodGetContactTypeByCategoryId, 0)]
        [TestCase(MethodGetInternalContactUserList, 0)]
        [TestCase(MethodAddInternalContact, 0)]
        [TestCase(MethodAddExternalContact, 0)]
        [Category("AUT Explore")]
        public void AUT_Contact_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (Contact) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Contact" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Contact_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}