using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OGS.EMFExtension.Core;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OGS.EMFExtension.Core
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OGS.EMFExtension.Core.EMFExtensionFactory" />)
    ///     and namespace <see cref="Onyx.OGS.EMFExtension.Core"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class EMFExtensionFactoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EMFExtensionFactory" />)
        /// </summary>
        public EMFExtensionFactoryTest() : base(typeof(EMFExtensionFactory))
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

        #region General Initializer : Class (EMFExtensionFactory) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _eMFExtensionFactoryInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="EMFExtensionFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _eMFExtensionFactoryInstanceType = typeof(EMFExtensionFactory);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EMFExtensionFactory) Initializer

        #region Methods

        private const string MethodGetConfig = "GetConfig";
        private const string MethodCreateInstance = "CreateInstance";

        #endregion

        #region Fields

        private const string Field_EMFExtensionConfig = "_EMFExtensionConfig";

        #endregion

        #endregion

        #region General Initializer : Class (EMFExtensionFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EMFExtensionFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EMFExtensionFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EMFExtensionFactory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EMFExtensionFactory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EMFExtensionFactory_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EMFExtensionFactory)

        #region General Initializer : Class (EMFExtensionFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="EMFExtensionFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetConfig, 0)]
        [TestCase(MethodCreateInstance, 0)]
        public void AUT_EMFExtensionFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (EMFExtensionFactory) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="EMFExtensionFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_EMFExtensionConfig)]
        [Category("AUT Fields")]
        public void AUT_EMFExtensionFactory_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EMFExtensionFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="EMFExtensionFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EMFExtensionFactory_Is_Static_Type_Present_Test()
        {
            // Assert
            _eMFExtensionFactoryInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}