using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.ReturnJson" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ReturnJsonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReturnJson" />)
        /// </summary>
        public ReturnJsonTest() : base(typeof(ReturnJson))
        { }

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

        #region General Initializer : Class (ReturnJson) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _returnJsonInstanceType;
        private ReturnJson _returnJsonInstance;
        private ReturnJson _returnJsonInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReturnJson" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _returnJsonInstanceType = typeof(ReturnJson);
            _returnJsonInstanceFixture = this.Create<ReturnJson>(false);
            _returnJsonInstance = _returnJsonInstanceFixture ?? this.Create<ReturnJson>(true);
            CurrentInstance = _returnJsonInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReturnJson) Initializer

        #region Properties

        private const string PropertyParametersReturn = "ParametersReturn";

        #endregion

        #endregion

        #region General Initializer : Class (ReturnJson) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReturnJson" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReturnJson_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReturnJson) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ReturnJson" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReturnJson_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReturnJson) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ReturnJson" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReturnJson_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ReturnJson)

        #region General Initializer : Class (ReturnJson) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ReturnJson" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyParametersReturn)]
        [Category("AUT Property")]
        public void AUT_ReturnJson_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ReturnJson) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReturnJson" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReturnJson_Is_Instance_Present_Test()
        {
            // Assert
            _returnJsonInstanceType.ShouldNotBeNull();
            _returnJsonInstance.ShouldNotBeNull();
            _returnJsonInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReturnJson) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReturnJson" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReturnJson_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _returnJsonInstance.ShouldBeAssignableTo<ReturnJson>();
            _returnJsonInstanceFixture.ShouldBeAssignableTo<ReturnJson>();
            CurrentInstance.ShouldBeAssignableTo<ReturnJson>();
        }

        #endregion

        #region General Constructor : Class (ReturnJson) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ReturnJson_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReturnJson instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (ReturnJson) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReturnJson_Class_All_Properties_Getter_Settter_Test()
        {
            // Arrange
            var parametersReturn = this.CreateType<ParametersReturn>();

            // Act
            _returnJsonInstanceFixture.ParametersReturn = parametersReturn;

            // Assert
            _returnJsonInstanceFixture.ParametersReturn.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (ReturnJson) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyParametersReturn)]
        public void AUT_ReturnJson_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ReturnJson) => Property (ParametersReturn) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReturnJson_ParametersReturn_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParametersReturn);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyParametersReturn);
            Action currentAction = () => propertyInfo.SetValue(_returnJsonInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReturnJson) => Property (ParametersReturn) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ReturnJson_Public_Class_ParametersReturn_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParametersReturn);
            var propertyInfo = this.GetPropertyInfo(PropertyParametersReturn);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion
    }
}