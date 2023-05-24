using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.DispatchAgent" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DispatchAgentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="DispatchAgentNonPublicTypeName" />) using
        ///     Using a public type <see cref="DispatchAgentManager" /> to
        ///     create a non-public type.
        /// </summary>
        public DispatchAgentTest() : base(publicType: typeof(DispatchAgentManager), classNameWithNamespace: DispatchAgentNonPublicTypeName)
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

        private Type _dispatchAgentInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string DispatchAgentNonPublicTypeName = "NotificationService.Administration.DispatchAgent";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _dispatchAgentInstance;
        private object _dispatchAgentInstanceFixture;

        #region General Initializer : Class (DispatchAgent) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="DispatchAgent" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dispatchAgentInstanceFixture = this.CreateNonPublicType(DispatchAgentNonPublicTypeName);
            _dispatchAgentInstance = _dispatchAgentInstanceFixture;
            CurrentInstance = _dispatchAgentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DispatchAgent) Initializer

        #region Properties

        private const string PropertyIs24x7Agent = "Is24x7Agent";
        private const string PropertyHasError = "HasError";
        private const string PropertyDispatchBroker = "DispatchBroker";
        private const string PropertyDuration = "Duration";
        private const string PropertyStartTime = "StartTime";

        #endregion

        #region Methods

        private const string MethodCleanUP = "CleanUP";
        private const string MethodExecuteHelper = "ExecuteHelper";
        private const string MethodTriggetConditionHelper = "TriggetConditionHelper";
        private const string MethodHasMorerecords = "HasMorerecords";
        private const string MethodExecute = "Execute";
        private const string MethodStart = "Start";
        private const string MethodStop = "Stop";
        private const string MethodIsAgentStopped = "IsAgentStopped";

        #endregion

        #region Fields

        private const string FieldStatus = "Status";
        
        private const string Field_AgentStartTimeStamp = "_AgentStartTimeStamp";
        private const string FieldiLog = "iLog";
        private const string Field_OneTimeProcess = "_OneTimeProcess";
        private const string Field_ContinueOnError = "_ContinueOnError";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (DispatchAgent)

        #region General Initializer : Class (DispatchAgent) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DispatchAgent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCleanUP, 0)]
        [TestCase(MethodExecuteHelper, 0)]
        [TestCase(MethodTriggetConditionHelper, 0)]
        [TestCase(MethodHasMorerecords, 0)]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodStart, 0)]
        [TestCase(MethodStop, 0)]
        [TestCase(MethodIsAgentStopped, 0)]
        [Category("AUT Explore")]
        public void AUT_DispatchAgent_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DispatchAgent) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DispatchAgent" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DispatchAgent_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DispatchAgent) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DispatchAgent" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIs24x7Agent)]
        [TestCase(PropertyHasError)]
        [TestCase(PropertyDispatchBroker)]
        [TestCase(PropertyDuration)]
        [TestCase(PropertyStartTime)]
        [Category("AUT Property")]
        public void AUT_DispatchAgent_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (DispatchAgent) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DispatchAgent" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DispatchAgent_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (DispatchAgent) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DispatchAgent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldStatus)]
        [TestCase(Field_AgentStartTimeStamp)]
        [TestCase(FieldiLog)]
        [TestCase(Field_OneTimeProcess)]
        [TestCase(Field_ContinueOnError)]
        [Category("AUT Fields")]
        public void AUT_DispatchAgent_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DispatchAgent) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DispatchAgent" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DispatchAgent_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DispatchAgent) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="DispatchAgent" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DispatchAgent_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DispatchAgent) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIs24x7Agent)]
        [TestCase(PropertyHasError)]
        [TestCase(PropertyDispatchBroker)]
        [TestCase(PropertyDuration)]
        [TestCase(PropertyStartTime)]
        public void AUT_DispatchAgent_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (DispatchAgent) => Property (DispatchBroker) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DispatchAgent_Public_Class_DispatchBroker_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDispatchBroker);
            var propertyInfo = this.GetPropertyInfo(PropertyDispatchBroker);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DispatchAgent) => Property (Duration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DispatchAgent_Public_Class_Duration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDuration);
            var propertyInfo = this.GetPropertyInfo(PropertyDuration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DispatchAgent) => Property (HasError) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DispatchAgent_Public_Class_HasError_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHasError);
            var propertyInfo = this.GetPropertyInfo(PropertyHasError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DispatchAgent) => Property (Is24x7Agent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DispatchAgent_Public_Class_Is24x7Agent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIs24x7Agent);
            var propertyInfo = this.GetPropertyInfo(PropertyIs24x7Agent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DispatchAgent) => Property (StartTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_DispatchAgent_Public_Class_StartTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartTime);
            var propertyInfo = this.GetPropertyInfo(PropertyStartTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}