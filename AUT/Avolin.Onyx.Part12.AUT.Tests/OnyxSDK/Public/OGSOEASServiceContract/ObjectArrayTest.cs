using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OGSOEASServiceContract;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OGSOEASServiceContract
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASServiceContract.ObjectArray" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASServiceContract"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ObjectArrayTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ObjectArray" />)
        /// </summary>
        public ObjectArrayTest() : base(typeof(ObjectArray))
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

        #region General Initializer : Class (ObjectArray) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _objectArrayInstanceType;
        private ObjectArray _objectArrayInstance;
        private ObjectArray _objectArrayInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ObjectArray" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _objectArrayInstanceType = typeof(ObjectArray);
            _objectArrayInstanceFixture = this.Create<ObjectArray>(false);
            _objectArrayInstance = _objectArrayInstanceFixture ?? this.Create<ObjectArray>(true);
            CurrentInstance = _objectArrayInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ObjectArray) Initializer

        #region Properties

        private const string Propertyitem = "item";

        #endregion

        #endregion

        #region General Initializer : Class (ObjectArray) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ObjectArray" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ObjectArray_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ObjectArray) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ObjectArray" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ObjectArray_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ObjectArray) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ObjectArray" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ObjectArray_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ObjectArray)

        #region General Initializer : Class (ObjectArray) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ObjectArray" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyitem)]
        [Category("AUT Property")]
        public void AUT_ObjectArray_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ObjectArray) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ObjectArray" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ObjectArray_Is_Instance_Present_Test()
        {
            // Assert
            _objectArrayInstanceType.ShouldNotBeNull();
            _objectArrayInstance.ShouldNotBeNull();
            _objectArrayInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ObjectArray) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ObjectArray" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ObjectArray_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _objectArrayInstance.ShouldBeAssignableTo<ObjectArray>();
            _objectArrayInstanceFixture.ShouldBeAssignableTo<ObjectArray>();
            CurrentInstance.ShouldBeAssignableTo<ObjectArray>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ObjectArray) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ObjectArray_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ObjectArray instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ObjectArray) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyitem)]
        public void AUT_ObjectArray_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ObjectArray) => Property (item) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ObjectArray_item_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyitem);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyitem);
            Action currentAction = () => propertyInfo.SetValue(_objectArrayInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ObjectArray) => Property (item) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ObjectArray_Public_Class_item_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyitem);
            var propertyInfo = this.GetPropertyInfo(Propertyitem);

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