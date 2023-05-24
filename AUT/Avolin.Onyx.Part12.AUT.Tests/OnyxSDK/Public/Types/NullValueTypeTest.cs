using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Types;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Types
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Types.NullValueType" />)
    ///     and namespace <see cref="OnyxSDK.Public.Types"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NullValueTypeTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NullValueType" />)
        /// </summary>
        public NullValueTypeTest() : base(typeof(NullValueType))
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

        #region General Initializer : Class (NullValueType) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _nullValueTypeInstanceType;
        private NullValueType _nullValueTypeInstance;
        private NullValueType _nullValueTypeInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NullValueType" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _nullValueTypeInstanceType = typeof(NullValueType);
            _nullValueTypeInstanceFixture = this.Create<NullValueType>(false);
            _nullValueTypeInstance = _nullValueTypeInstanceFixture ?? this.Create<NullValueType>(true);
            CurrentInstance = _nullValueTypeInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NullValueType) Initializer

        #region Properties

        private const string PropertyNull = "Null";
        private const string PropertyValue = "Value";

        #endregion

        #endregion

        #region General Initializer : Class (NullValueType) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NullValueType" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NullValueType_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NullValueType) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NullValueType" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NullValueType_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NullValueType) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NullValueType" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NullValueType_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NullValueType)

        #region General Initializer : Class (NullValueType) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NullValueType" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNull)]
        [TestCase(PropertyValue)]
        [Category("AUT Property")]
        public void AUT_NullValueType_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NullValueType) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NullValueType" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NullValueType_Is_Instance_Present_Test()
        {
            // Assert
            _nullValueTypeInstanceType.ShouldNotBeNull();
            _nullValueTypeInstance.ShouldNotBeNull();
            _nullValueTypeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NullValueType) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NullValueType" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NullValueType_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _nullValueTypeInstance.ShouldBeAssignableTo<NullValueType>();
            _nullValueTypeInstanceFixture.ShouldBeAssignableTo<NullValueType>();
            CurrentInstance.ShouldBeAssignableTo<NullValueType>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NullValueType) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NullValueType_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NullValueType instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (NullValueType) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NullValueType_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var value = this.CreateType<string>();
            NullValueType instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NullValueType(value);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _nullValueTypeInstance.ShouldNotBeNull();
            _nullValueTypeInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NullValueType>();
        }

        #endregion

        #region General Constructor : Class (NullValueType) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NullValueType_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var value = this.CreateType<string>();
            NullValueType instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NullValueType(value);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _nullValueTypeInstance.ShouldNotBeNull();
            _nullValueTypeInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (NullValueType) instance created

        /// <summary>
        ///     Class (<see cref="NullValueType" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NullValueType_Is_Created_Test()
        {
            // Assert
            _nullValueTypeInstance.ShouldNotBeNull();
            _nullValueTypeInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (NullValueType) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="NullValueType" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_NullValueType_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (NullValueType) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="NullValueType" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NullValueType_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (NullValueType) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="NullValueType" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NullValueType_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodNullValueTypeParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodNullValueTypeParametersTypes);
        }

        #endregion

        #region General Constructor : Class (NullValueType) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="NullValueType" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NullValueType_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodNullValueTypeParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodNullValueTypeParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NullValueType) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNull)]
        [TestCase(PropertyValue)]
        public void AUT_NullValueType_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NullValueType) => Property (Null) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NullValueType_Public_Class_Null_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNull);
            var propertyInfo = this.GetPropertyInfo(PropertyNull);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NullValueType) => Property (Value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NullValueType_Public_Class_Value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValue);
            var propertyInfo = this.GetPropertyInfo(PropertyValue);

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