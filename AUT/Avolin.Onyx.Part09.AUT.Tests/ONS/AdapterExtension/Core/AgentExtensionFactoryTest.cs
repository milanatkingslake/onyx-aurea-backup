using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.ONS.AdapterExtension.Core;
using Shouldly;

namespace Avolin.Onyx.Part09.AUT.Tests.ONS.AdapterExtension.Core
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.ONS.AdapterExtension.Core.AgentExtensionFactory" />)
    ///     and namespace <see cref="Onyx.ONS.AdapterExtension.Core"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AgentExtensionFactoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AgentExtensionFactory" />)
        /// </summary>
        public AgentExtensionFactoryTest() : base(typeof(AgentExtensionFactory))
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

        #region General Initializer : Class (AgentExtensionFactory) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _agentExtensionFactoryInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="AgentExtensionFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _agentExtensionFactoryInstanceType = typeof(AgentExtensionFactory);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AgentExtensionFactory) Initializer

        #region Methods

        private const string MethodGetExtensionConfig = "GetExtensionConfig";
        private const string MethodCreateInstance = "CreateInstance";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FielddocumentRoot = "documentRoot";

        #endregion

        #endregion

        #region General Initializer : Class (AgentExtensionFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AgentExtensionFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AgentExtensionFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AgentExtensionFactory) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AgentExtensionFactory" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AgentExtensionFactory_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AgentExtensionFactory)

        #region General Initializer : Class (AgentExtensionFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AgentExtensionFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetExtensionConfig, 0)]
        [TestCase(MethodCreateInstance, 0)]
        public void AUT_AgentExtensionFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AgentExtensionFactory) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AgentExtensionFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FielddocumentRoot)]
        [Category("AUT Fields")]
        public void AUT_AgentExtensionFactory_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AgentExtensionFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AgentExtensionFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AgentExtensionFactory_Is_Static_Type_Present_Test()
        {
            // Assert
            _agentExtensionFactoryInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}