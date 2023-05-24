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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OGS.EMFExtension.Template.TaskEmailDataProfileExtensionExtension" />)
    ///     and namespace <see cref="Onyx.OGS.EMFExtension.Template"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TaskEmailDataProfileExtensionExtensionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="TaskEmailDataProfileExtensionExtensionNonPublicTypeName" />) using
        ///     Using a public type <see cref="NewBusinessRuleActionInterface" /> to
        ///     create a non-public type.
        /// </summary>
        public TaskEmailDataProfileExtensionExtensionTest() : base(publicType: typeof(NewBusinessRuleActionInterface), classNameWithNamespace: TaskEmailDataProfileExtensionExtensionNonPublicTypeName)
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

        private Type _taskEmailDataProfileExtensionExtensionInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string TaskEmailDataProfileExtensionExtensionNonPublicTypeName = "Onyx.OGS.EMFExtension.Template.TaskEmailDataProfileExtensionExtension";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _taskEmailDataProfileExtensionExtensionInstance;
        private object _taskEmailDataProfileExtensionExtensionInstanceFixture;

        #region General Initializer : Class (TaskEmailDataProfileExtensionExtension) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="TaskEmailDataProfileExtensionExtension" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _taskEmailDataProfileExtensionExtensionInstanceFixture = this.CreateNonPublicType(TaskEmailDataProfileExtensionExtensionNonPublicTypeName);
            _taskEmailDataProfileExtensionExtensionInstance = _taskEmailDataProfileExtensionExtensionInstanceFixture;
            CurrentInstance = _taskEmailDataProfileExtensionExtensionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TaskEmailDataProfileExtensionExtension) Initializer

        #region Methods

        private const string MethodGetEmailProfileData = "GetEmailProfileData";
        private const string MethodFillReferenceParameters = "FillReferenceParameters";
        private const string MethodFillUserName = "FillUserName";
        private const string MethodTemplateMethod = "TemplateMethod";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (TaskEmailDataProfileExtensionExtension)

        #region General Initializer : Class (TaskEmailDataProfileExtensionExtension) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfileExtensionExtension" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetEmailProfileData, 0)]
        [TestCase(MethodFillReferenceParameters, 0)]
        [TestCase(MethodFillUserName, 0)]
        [TestCase(MethodTemplateMethod, 0)]
        [Category("AUT Explore")]
        public void AUT_TaskEmailDataProfileExtensionExtension_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TaskEmailDataProfileExtensionExtension) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TaskEmailDataProfileExtensionExtension" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TaskEmailDataProfileExtensionExtension_Explore_Reflection_Based_NonListed_Methods_Test()
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