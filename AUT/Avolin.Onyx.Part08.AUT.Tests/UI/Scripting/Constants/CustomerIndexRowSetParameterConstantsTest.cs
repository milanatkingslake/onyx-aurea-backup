using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Constants;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Constants.CustomerIndexRowSetParameterConstants" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomerIndexRowSetParameterConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomerIndexRowSetParameterConstants" />)
        /// </summary>
        public CustomerIndexRowSetParameterConstantsTest() : base(typeof(CustomerIndexRowSetParameterConstants))
        { }

        #region Category : General

        #region Category : Initializer

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

        #region General Initializer : Class (CustomerIndexRowSetParameterConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customerIndexRowSetParameterConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="CustomerIndexRowSetParameterConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customerIndexRowSetParameterConstantsInstanceType = typeof(CustomerIndexRowSetParameterConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomerIndexRowSetParameterConstants) Initializer

        #region Fields

        private const string FieldICUSTOMER_TYPE = "ICUSTOMER_TYPE";
        private const string FieldSECONDARY_ID = "SECONDARY_ID";
        private const string FieldVCH_COMPANY_NAME = "VCH_COMPANY_NAME";
        private const string FieldVCH_SALUTATION = "VCH_SALUTATION";
        private const string FieldVCH_FIRST_NAME = "VCH_FIRST_NAME";
        private const string FieldVCH_LAST_NAME = "VCH_LAST_NAME";
        private const string FieldVCH_SUFFIX = "VCH_SUFFIX";
        private const string FieldPRIMARY_CONTACT_PRIMARY_ID = "PRIMARY_CONTACT_PRIMARY_ID";
        private const string FieldPRIMARY_CONTACT_SECONDARY_ID = "PRIMARY_CONTACT_SECONDARY_ID";

        #endregion

        #endregion

        #region General Initializer : Class (CustomerIndexRowSetParameterConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomerIndexRowSetParameterConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerIndexRowSetParameterConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomerIndexRowSetParameterConstants)

        #region General Initializer : Class (CustomerIndexRowSetParameterConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomerIndexRowSetParameterConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldICUSTOMER_TYPE)]
        [TestCase(FieldSECONDARY_ID)]
        [TestCase(FieldVCH_COMPANY_NAME)]
        [TestCase(FieldVCH_SALUTATION)]
        [TestCase(FieldVCH_FIRST_NAME)]
        [TestCase(FieldVCH_LAST_NAME)]
        [TestCase(FieldVCH_SUFFIX)]
        [TestCase(FieldPRIMARY_CONTACT_PRIMARY_ID)]
        [TestCase(FieldPRIMARY_CONTACT_SECONDARY_ID)]
        [Category("AUT Fields")]
        public void AUT_CustomerIndexRowSetParameterConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (CustomerIndexRowSetParameterConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomerIndexRowSetParameterConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomerIndexRowSetParameterConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _customerIndexRowSetParameterConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}