using System;
using System.Collections.Generic;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Errors" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ErrorsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Errors" />)
        /// </summary>
        public ErrorsTest() : base(typeof(Errors))
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

        #region General Initializer : Class (Errors) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _errorsInstanceType;
        private Errors _errorsInstance;
        private Errors _errorsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Errors" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _errorsInstanceType = typeof(Errors);
            _errorsInstanceFixture = this.Create<Errors>(false);
            _errorsInstance = _errorsInstanceFixture ?? this.Create<Errors>(true);
            CurrentInstance = _errorsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Errors) Initializer

        #region Properties

        private const string PropertyError = "Error";

        #endregion

        #endregion

        #region General Initializer : Class (Errors) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Errors" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Errors_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Errors) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Errors" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Errors_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Errors) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Errors" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Errors_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Errors)

        #region General Initializer : Class (Errors) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Errors" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyError)]
        [Category("AUT Property")]
        public void AUT_Errors_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Errors) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Errors" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Errors_Is_Instance_Present_Test()
        {
            // Assert
            _errorsInstanceType.ShouldNotBeNull();
            _errorsInstance.ShouldNotBeNull();
            _errorsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Errors) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Errors" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Errors_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _errorsInstance.ShouldBeAssignableTo<Errors>();
            _errorsInstanceFixture.ShouldBeAssignableTo<Errors>();
            CurrentInstance.ShouldBeAssignableTo<Errors>();
        }

        #endregion

        #region General Constructor : Class (Errors) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Errors_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Errors instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (Errors) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Errors_Class_All_Properties_Getter_Settter_Test()
        {
            // Arrange
            var error = this.CreateType<List<object>>();

            // Act
            _errorsInstanceFixture.Error = error;

            // Assert
            _errorsInstanceFixture.Error.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (Errors) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyError)]
        public void AUT_Errors_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Errors) => Property (Error) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Errors_Public_Class_Error_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError);
            var propertyInfo = this.GetPropertyInfo(PropertyError);

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