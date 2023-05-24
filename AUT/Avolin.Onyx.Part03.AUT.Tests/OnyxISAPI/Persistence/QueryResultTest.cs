using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI.Persistence
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.QueryResult" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class QueryResultTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryResult" />)
        /// </summary>
        public QueryResultTest() : base(typeof(QueryResult))
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

        #region General Initializer : Class (QueryResult) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryResultInstanceType;
        private QueryResult _queryResultInstance;
        private QueryResult _queryResultInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QueryResult" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryResultInstanceType = typeof(QueryResult);
            _queryResultInstanceFixture = this.Create<QueryResult>(false);
            _queryResultInstance = _queryResultInstanceFixture ?? this.Create<QueryResult>(true);
            CurrentInstance = _queryResultInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryResult) Initializer

        #region Properties

        private const string PropertyRequestSessionId = "RequestSessionId";
        private const string PropertyPageIndex = "PageIndex";
        private const string PropertyPageRecords = "PageRecords";
        private const string PropertyQueryProfile = "QueryProfile";

        #endregion

        #endregion

        #region General Initializer : Class (QueryResult) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryResult" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryResult_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryResult) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="QueryResult" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryResult_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryResult) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryResult" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryResult_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryResult)

        #region General Initializer : Class (QueryResult) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryResult" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyRequestSessionId)]
        [TestCase(PropertyPageIndex)]
        [TestCase(PropertyPageRecords)]
        [TestCase(PropertyQueryProfile)]
        [Category("AUT Property")]
        public void AUT_QueryResult_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (QueryResult) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QueryResult" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryResult_Is_Instance_Present_Test()
        {
            // Assert
            _queryResultInstanceType.ShouldNotBeNull();
            _queryResultInstance.ShouldNotBeNull();
            _queryResultInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (QueryResult) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryResult" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryResult_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryResultInstance.ShouldBeAssignableTo<QueryResult>();
            _queryResultInstanceFixture.ShouldBeAssignableTo<QueryResult>();
            CurrentInstance.ShouldBeAssignableTo<QueryResult>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (QueryResult) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QueryResult_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            QueryResult instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (QueryResult) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyRequestSessionId)]
        [TestCase(PropertyPageIndex)]
        [TestCase(PropertyPageRecords)]
        [TestCase(PropertyQueryProfile)]
        public void AUT_QueryResult_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (QueryResult) => Property (PageIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryResult_Public_Class_PageIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPageIndex);
            var propertyInfo = this.GetPropertyInfo(PropertyPageIndex);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryResult) => Property (PageRecords) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryResult_Public_Class_PageRecords_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPageRecords);
            var propertyInfo = this.GetPropertyInfo(PropertyPageRecords);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryResult) => Property (QueryProfile) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryResult_QueryProfile_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryProfile);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyQueryProfile);
            Action currentAction = () => propertyInfo.SetValue(_queryResultInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (QueryResult) => Property (QueryProfile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryResult_Public_Class_QueryProfile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryProfile);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryProfile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryResult) => Property (RequestSessionId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryResult_RequestSessionId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestSessionId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRequestSessionId);
            Action currentAction = () => propertyInfo.SetValue(_queryResultInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (QueryResult) => Property (RequestSessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryResult_Public_Class_RequestSessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestSessionId);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestSessionId);

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