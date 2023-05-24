using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OGS.EMFExtension.Template;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OGS.EMFExtension.Template
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OGS.EMFExtension.Template.IncidentEmailDataProfileExtension" />)
    ///     and namespace <see cref="Onyx.OGS.EMFExtension.Template"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IncidentEmailDataProfileExtensionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="IncidentEmailDataProfileExtensionNonPublicTypeName" />) using
        ///     Using a public type <see cref="NewBusinessRuleActionInterface" /> to
        ///     create a non-public type.
        /// </summary>
        public IncidentEmailDataProfileExtensionTest() : base(publicType: typeof(NewBusinessRuleActionInterface), classNameWithNamespace: IncidentEmailDataProfileExtensionNonPublicTypeName)
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

        private Type _incidentEmailDataProfileExtensionInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string IncidentEmailDataProfileExtensionNonPublicTypeName = "Onyx.OGS.EMFExtension.Template.IncidentEmailDataProfileExtension";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _incidentEmailDataProfileExtensionInstance;
        private object _incidentEmailDataProfileExtensionInstanceFixture;

        #region General Initializer : Class (IncidentEmailDataProfileExtension) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="IncidentEmailDataProfileExtension" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentEmailDataProfileExtensionInstanceFixture = this.CreateNonPublicType(IncidentEmailDataProfileExtensionNonPublicTypeName);
            _incidentEmailDataProfileExtensionInstance = _incidentEmailDataProfileExtensionInstanceFixture;
            CurrentInstance = _incidentEmailDataProfileExtensionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IncidentEmailDataProfileExtension) Initializer

        #region Methods

        private const string MethodGetEmailProfileData = "GetEmailProfileData";
        private const string MethodFillReferenceParameters = "FillReferenceParameters";
        private const string MethodFillUserName = "FillUserName";
        private const string MethodFillProductName = "FillProductName";
        private const string MethodTemplateMethod = "TemplateMethod";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (IncidentEmailDataProfileExtension)

        #region General Initializer : Class (IncidentEmailDataProfileExtension) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="IncidentEmailDataProfileExtension" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetEmailProfileData, 0)]
        [TestCase(MethodFillReferenceParameters, 0)]
        [TestCase(MethodFillUserName, 0)]
        [TestCase(MethodFillProductName, 0)]
        [TestCase(MethodTemplateMethod, 0)]
        [Category("AUT Explore")]
        public void AUT_IncidentEmailDataProfileExtension_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (IncidentEmailDataProfileExtension) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IncidentEmailDataProfileExtension" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentEmailDataProfileExtension_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}