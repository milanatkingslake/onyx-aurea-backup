using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxQASIntegration;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxQASIntegration
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.Utilities" />)
    ///     and namespace <see cref="OnyxQASIntegration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UtilitiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="UtilitiesNonPublicTypeName" />) using
        ///     Using a public type <see cref="SearchAddress" /> to
        ///     create a non-public type.
        /// </summary>
        public UtilitiesTest() : base(publicType: typeof(SearchAddress), classNameWithNamespace: UtilitiesNonPublicTypeName)
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

        private Type _utilitiesInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string UtilitiesNonPublicTypeName = "OnyxQASIntegration.Utilities";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _utilitiesInstance;
        private object _utilitiesInstanceFixture;

        #region General Initializer : Class (Utilities) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Utilities" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _utilitiesInstanceFixture = this.CreateNonPublicType(UtilitiesNonPublicTypeName);
            _utilitiesInstance = _utilitiesInstanceFixture;
            CurrentInstance = _utilitiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Utilities) Initializer

        #region Methods

        private const string MethodStandardizeCountry = "StandardizeCountry";
        private const string MethodGetLocalXMLString = "GetLocalXMLString";
        private const string MethodExtractVerificationLevel = "ExtractVerificationLevel";
        private const string MethodverificationLvlFromFields = "verificationLvlFromFields";
        private const string MethodExtractReturnMessage = "ExtractReturnMessage";
        private const string MethodreturnMessageFromFields = "returnMessageFromFields";
        private const string MethodExtractReturnFields = "ExtractReturnFields";
        private const string MethodUSReturnCodeToString = "USReturnCodeToString";
        private const string MethodCANReturnCodeToString = "CANReturnCodeToString";
        private const string MethodExtractErrors = "ExtractErrors";
        private const string MethoderrorsFromFields = "errorsFromFields";
        private const string MethodUSErrorCodeToString = "USErrorCodeToString";
        private const string MethodCANErrorCodeToString = "CANErrorCodeToString";

        #endregion

        #region Fields

        private const string FieldcountryMappings = "countryMappings";
        private const string FieldusErrorCodes = "usErrorCodes";
        private const string FieldcanErrorCodes = "canErrorCodes";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Utilities)

        #region General Initializer : Class (Utilities) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Utilities" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodStandardizeCountry, 0)]
        [TestCase(MethodGetLocalXMLString, 0)]
        [TestCase(MethodExtractVerificationLevel, 0)]
        [TestCase(MethodExtractVerificationLevel, 1)]
        [TestCase(MethodverificationLvlFromFields, 0)]
        [TestCase(MethodExtractReturnMessage, 0)]
        [TestCase(MethodExtractReturnMessage, 1)]
        [TestCase(MethodreturnMessageFromFields, 0)]
        [TestCase(MethodExtractReturnFields, 0)]
        [TestCase(MethodExtractReturnFields, 1)]
        [TestCase(MethodUSReturnCodeToString, 0)]
        [TestCase(MethodCANReturnCodeToString, 0)]
        [TestCase(MethodExtractErrors, 0)]
        [TestCase(MethodExtractErrors, 1)]
        [TestCase(MethoderrorsFromFields, 0)]
        [TestCase(MethodUSErrorCodeToString, 0)]
        [TestCase(MethodCANErrorCodeToString, 0)]
        [Category("AUT Explore")]
        public void AUT_Utilities_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Utilities) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Utilities" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Utilities_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Utilities) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Utilities" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldcountryMappings)]
        [TestCase(FieldusErrorCodes)]
        [TestCase(FieldcanErrorCodes)]
        [Category("AUT Fields")]
        public void AUT_Utilities_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Utilities) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Utilities" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Utilities_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}