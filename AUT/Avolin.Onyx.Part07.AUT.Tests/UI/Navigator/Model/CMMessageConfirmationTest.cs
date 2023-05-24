using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.CMMessageConfirmation" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CMMessageConfirmationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CMMessageConfirmation" />)
        /// </summary>
        public CMMessageConfirmationTest() : base(typeof(CMMessageConfirmation))
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

        #region General Initializer : Class (CMMessageConfirmation) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cMMessageConfirmationInstanceType;
        private CMMessageConfirmation _cMMessageConfirmationInstance;
        private CMMessageConfirmation _cMMessageConfirmationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CMMessageConfirmation" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cMMessageConfirmationInstanceType = typeof(CMMessageConfirmation);
            _cMMessageConfirmationInstanceFixture = this.Create<CMMessageConfirmation>(false);
            _cMMessageConfirmationInstance = _cMMessageConfirmationInstanceFixture ?? this.Create<CMMessageConfirmation>(true);
            CurrentInstance = _cMMessageConfirmationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CMMessageConfirmation) Initializer

        #region Properties

        private const string PropertyMessageType = "MessageType";
        private const string PropertyMessageTitle = "MessageTitle";
        private const string PropertyMessagePrimaryText = "MessagePrimaryText";
        private const string PropertyMessageAction = "MessageAction";

        #endregion

        #endregion

        #region General Initializer : Class (CMMessageConfirmation) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CMMessageConfirmation_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CMMessageConfirmation) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CMMessageConfirmation_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CMMessageConfirmation) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CMMessageConfirmation_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CMMessageConfirmation)

        #region General Initializer : Class (CMMessageConfirmation) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyMessageType)]
        [TestCase(PropertyMessageTitle)]
        [TestCase(PropertyMessagePrimaryText)]
        [TestCase(PropertyMessageAction)]
        [Category("AUT Property")]
        public void AUT_CMMessageConfirmation_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (CMMessageConfirmation) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CMMessageConfirmation_Is_Instance_Present_Test()
        {
            // Assert
            _cMMessageConfirmationInstanceType.ShouldNotBeNull();
            _cMMessageConfirmationInstance.ShouldNotBeNull();
            _cMMessageConfirmationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CMMessageConfirmation) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CMMessageConfirmation_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _cMMessageConfirmationInstance.ShouldBeAssignableTo<CMMessageConfirmation>();
            _cMMessageConfirmationInstanceFixture.ShouldBeAssignableTo<CMMessageConfirmation>();
            CurrentInstance.ShouldBeAssignableTo<CMMessageConfirmation>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CMMessageConfirmation) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMMessageConfirmation_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CMMessageConfirmation instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (CMMessageConfirmation) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMMessageConfirmation_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var errorMessage = this.CreateType<string>();
            CMMessageConfirmation instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CMMessageConfirmation(errorMessage);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _cMMessageConfirmationInstance.ShouldNotBeNull();
            _cMMessageConfirmationInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<CMMessageConfirmation>();
        }

        #endregion

        #region General Constructor : Class (CMMessageConfirmation) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMMessageConfirmation_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var errorMessage = this.CreateType<string>();
            CMMessageConfirmation instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CMMessageConfirmation(errorMessage);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _cMMessageConfirmationInstance.ShouldNotBeNull();
            _cMMessageConfirmationInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (CMMessageConfirmation) instance created

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMMessageConfirmation_Is_Created_Test()
        {
            // Assert
            _cMMessageConfirmationInstance.ShouldNotBeNull();
            _cMMessageConfirmationInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (CMMessageConfirmation) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="CMMessageConfirmation" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_CMMessageConfirmation_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (CMMessageConfirmation) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="CMMessageConfirmation" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMMessageConfirmation_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (CMMessageConfirmation) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CMMessageConfirmation" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMMessageConfirmation_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodCMMessageConfirmationParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCMMessageConfirmationParametersTypes);
        }

        #endregion

        #region General Constructor : Class (CMMessageConfirmation) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="CMMessageConfirmation" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMMessageConfirmation_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCMMessageConfirmationParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCMMessageConfirmationParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CMMessageConfirmation) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyMessageType)]
        [TestCase(PropertyMessageTitle)]
        [TestCase(PropertyMessagePrimaryText)]
        [TestCase(PropertyMessageAction)]
        public void AUT_CMMessageConfirmation_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CMMessageConfirmation) => Property (MessageAction) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CMMessageConfirmation_Public_Class_MessageAction_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessageAction);
            var propertyInfo = this.GetPropertyInfo(PropertyMessageAction);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CMMessageConfirmation) => Property (MessagePrimaryText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CMMessageConfirmation_Public_Class_MessagePrimaryText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessagePrimaryText);
            var propertyInfo = this.GetPropertyInfo(PropertyMessagePrimaryText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CMMessageConfirmation) => Property (MessageTitle) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CMMessageConfirmation_Public_Class_MessageTitle_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessageTitle);
            var propertyInfo = this.GetPropertyInfo(PropertyMessageTitle);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CMMessageConfirmation) => Property (MessageType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CMMessageConfirmation_Public_Class_MessageType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessageType);
            var propertyInfo = this.GetPropertyInfo(PropertyMessageType);

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