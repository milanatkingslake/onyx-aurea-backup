using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ActionEndPoint" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ActionEndPointTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ActionEndPoint" />)
        /// </summary>
        public ActionEndPointTest() : base(typeof(ActionEndPoint))
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

        #region General Initializer : Class (ActionEndPoint) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _actionEndPointInstanceType;
        private ActionEndPoint _actionEndPointInstance;
        private ActionEndPoint _actionEndPointInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ActionEndPoint" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _actionEndPointInstanceType = typeof(ActionEndPoint);
            _actionEndPointInstanceFixture = this.Create<ActionEndPoint>(false);
            _actionEndPointInstance = _actionEndPointInstanceFixture ?? this.Create<ActionEndPoint>(true);
            CurrentInstance = _actionEndPointInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ActionEndPoint) Initializer

        #region Properties

        private const string PropertyId = "Id";
        private const string PropertyUri = "Uri";
        private const string PropertyPriority = "Priority";
        private const string PropertyTypeId = "TypeId";
        private const string PropertyTypeName = "TypeName";
        private const string PropertyEndPointProperties = "EndPointProperties";

        #endregion

        #endregion

        #region General Initializer : Class (ActionEndPoint) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ActionEndPoint" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionEndPoint_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActionEndPoint) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ActionEndPoint" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionEndPoint_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActionEndPoint) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ActionEndPoint" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionEndPoint_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ActionEndPoint)

        #region General Initializer : Class (ActionEndPoint) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ActionEndPoint" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyId)]
        [TestCase(PropertyUri)]
        [TestCase(PropertyPriority)]
        [TestCase(PropertyTypeId)]
        [TestCase(PropertyTypeName)]
        [TestCase(PropertyEndPointProperties)]
        [Category("AUT Property")]
        public void AUT_ActionEndPoint_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ActionEndPoint) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ActionEndPoint" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ActionEndPoint_Is_Instance_Present_Test()
        {
            // Assert
            _actionEndPointInstanceType.ShouldNotBeNull();
            _actionEndPointInstance.ShouldNotBeNull();
            _actionEndPointInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ActionEndPoint) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ActionEndPoint" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ActionEndPoint_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _actionEndPointInstance.ShouldBeAssignableTo<ActionEndPoint>();
            _actionEndPointInstanceFixture.ShouldBeAssignableTo<ActionEndPoint>();
            CurrentInstance.ShouldBeAssignableTo<ActionEndPoint>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ActionEndPoint) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ActionEndPoint_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ActionEndPoint instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ActionEndPoint) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyId)]
        [TestCase(PropertyUri)]
        [TestCase(PropertyPriority)]
        [TestCase(PropertyTypeId)]
        [TestCase(PropertyTypeName)]
        [TestCase(PropertyEndPointProperties)]
        public void AUT_ActionEndPoint_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ActionEndPoint) => Property (EndPointProperties) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionEndPoint_Public_Class_EndPointProperties_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointProperties);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointProperties);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionEndPoint) => Property (Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionEndPoint_Public_Class_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var propertyInfo = this.GetPropertyInfo(PropertyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionEndPoint) => Property (Priority) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionEndPoint_Public_Class_Priority_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPriority);
            var propertyInfo = this.GetPropertyInfo(PropertyPriority);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionEndPoint) => Property (TypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionEndPoint_Public_Class_TypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTypeId);
            var propertyInfo = this.GetPropertyInfo(PropertyTypeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionEndPoint) => Property (TypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionEndPoint_Public_Class_TypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTypeName);
            var propertyInfo = this.GetPropertyInfo(PropertyTypeName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionEndPoint) => Property (Uri) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionEndPoint_Public_Class_Uri_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUri);
            var propertyInfo = this.GetPropertyInfo(PropertyUri);

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