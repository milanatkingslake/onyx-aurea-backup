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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.RowSet" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RowSetTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RowSet" />)
        /// </summary>
        public RowSetTest() : base(typeof(RowSet))
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

        #region General Initializer : Class (RowSet) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _rowSetInstanceType;
        private RowSet _rowSetInstance;
        private RowSet _rowSetInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RowSet" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _rowSetInstanceType = typeof(RowSet);
            _rowSetInstanceFixture = this.Create<RowSet>(false);
            _rowSetInstance = _rowSetInstanceFixture ?? this.Create<RowSet>(true);
            CurrentInstance = _rowSetInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RowSet) Initializer

        #region Properties

        private const string PropertyColumnDefinitions = "ColumnDefinitions";
        private const string PropertyRows = "Rows";

        #endregion

        #endregion

        #region General Initializer : Class (RowSet) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RowSet" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RowSet_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RowSet) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RowSet" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RowSet_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RowSet) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RowSet" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RowSet_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RowSet)

        #region General Initializer : Class (RowSet) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="RowSet" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyColumnDefinitions)]
        [TestCase(PropertyRows)]
        [Category("AUT Property")]
        public void AUT_RowSet_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RowSet) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RowSet" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RowSet_Is_Instance_Present_Test()
        {
            // Assert
            _rowSetInstanceType.ShouldNotBeNull();
            _rowSetInstance.ShouldNotBeNull();
            _rowSetInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RowSet) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RowSet" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RowSet_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _rowSetInstance.ShouldBeAssignableTo<RowSet>();
            _rowSetInstanceFixture.ShouldBeAssignableTo<RowSet>();
            CurrentInstance.ShouldBeAssignableTo<RowSet>();
        }

        #endregion

        #region General Constructor : Class (RowSet) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RowSet_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RowSet instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (RowSet) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RowSet_Class_All_Properties_Getter_Settter_Test()
        {
            // Arrange
            var columnDefinitions = this.CreateType<List<ColumnDefinition1>>();
            var rows = this.CreateType<List<Row1>>();

            // Act
            _rowSetInstanceFixture.ColumnDefinitions = columnDefinitions;
            _rowSetInstanceFixture.Rows = rows;

            // Assert
            _rowSetInstanceFixture.ColumnDefinitions.ShouldNotBeNull();
            _rowSetInstanceFixture.Rows.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (RowSet) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyColumnDefinitions)]
        [TestCase(PropertyRows)]
        public void AUT_RowSet_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (RowSet) => Property (ColumnDefinitions) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RowSet_Public_Class_ColumnDefinitions_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyColumnDefinitions);
            var propertyInfo = this.GetPropertyInfo(PropertyColumnDefinitions);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (RowSet) => Property (Rows) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_RowSet_Public_Class_Rows_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRows);
            var propertyInfo = this.GetPropertyInfo(PropertyRows);

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