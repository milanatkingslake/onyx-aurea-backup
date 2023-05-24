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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ColumnDefinition1" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ColumnDefinition1Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ColumnDefinition1" />)
        /// </summary>
        public ColumnDefinition1Test() : base(typeof(ColumnDefinition1))
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

        #region General Initializer : Class (ColumnDefinition1) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _columnDefinition1InstanceType;
        private ColumnDefinition1 _columnDefinition1Instance;
        private ColumnDefinition1 _columnDefinition1InstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ColumnDefinition1" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _columnDefinition1InstanceType = typeof(ColumnDefinition1);
            _columnDefinition1InstanceFixture = this.Create<ColumnDefinition1>(false);
            _columnDefinition1Instance = _columnDefinition1InstanceFixture ?? this.Create<ColumnDefinition1>(true);
            CurrentInstance = _columnDefinition1Instance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ColumnDefinition1) Initializer

        #region Properties

        private const string PropertyColumnDefinition = "ColumnDefinition";

        #endregion

        #endregion

        #region General Initializer : Class (ColumnDefinition1) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ColumnDefinition1" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ColumnDefinition1_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ColumnDefinition1) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ColumnDefinition1" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ColumnDefinition1_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ColumnDefinition1) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ColumnDefinition1" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ColumnDefinition1_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ColumnDefinition1)

        #region General Initializer : Class (ColumnDefinition1) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ColumnDefinition1" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyColumnDefinition)]
        [Category("AUT Property")]
        public void AUT_ColumnDefinition1_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ColumnDefinition1) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ColumnDefinition1" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ColumnDefinition1_Is_Instance_Present_Test()
        {
            // Assert
            _columnDefinition1InstanceType.ShouldNotBeNull();
            _columnDefinition1Instance.ShouldNotBeNull();
            _columnDefinition1InstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ColumnDefinition1) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ColumnDefinition1" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ColumnDefinition1_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _columnDefinition1Instance.ShouldBeAssignableTo<ColumnDefinition1>();
            _columnDefinition1InstanceFixture.ShouldBeAssignableTo<ColumnDefinition1>();
            CurrentInstance.ShouldBeAssignableTo<ColumnDefinition1>();
        }

        #endregion

        #region General Constructor : Class (ColumnDefinition1) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ColumnDefinition1_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ColumnDefinition1 instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (ColumnDefinition1) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ColumnDefinition1_Class_All_Properties_Getter_Settter_Test()
        {
            // Arrange
            var columnDefinition = this.CreateType<List<object>>();

            // Act
            _columnDefinition1InstanceFixture.ColumnDefinition = columnDefinition;

            // Assert
            _columnDefinition1InstanceFixture.ColumnDefinition.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (ColumnDefinition1) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyColumnDefinition)]
        public void AUT_ColumnDefinition1_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ColumnDefinition1) => Property (ColumnDefinition) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ColumnDefinition1_Public_Class_ColumnDefinition_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyColumnDefinition);
            var propertyInfo = this.GetPropertyInfo(PropertyColumnDefinition);

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