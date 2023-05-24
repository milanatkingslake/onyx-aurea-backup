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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.QueryInfo" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class QueryInfoTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryInfo" />)
        /// </summary>
        public QueryInfoTest() : base(typeof(QueryInfo))
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

        #region General Initializer : Class (QueryInfo) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryInfoInstanceType;
        private QueryInfo _queryInfoInstance;
        private QueryInfo _queryInfoInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QueryInfo" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryInfoInstanceType = typeof(QueryInfo);
            _queryInfoInstanceFixture = this.Create<QueryInfo>(false);
            _queryInfoInstance = _queryInfoInstanceFixture ?? this.Create<QueryInfo>(true);
            CurrentInstance = _queryInfoInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryInfo) Initializer

        #region Properties

        private const string PropertyQueryId = "QueryId";
        private const string PropertyQueryName = "QueryName";
        private const string PropertyQueryMode = "QueryMode";
        private const string PropertyQueryParameter = "QueryParameter";
        private const string PropertyProtectionMode = "ProtectionMode";
        private const string PropertyParentFolderId = "ParentFolderId";
        private const string PropertyNavigatorType = "NavigatorType";
        private const string PropertyNavigatorEntity = "NavigatorEntity";
        private const string PropertyOwnerId = "OwnerId";
        private const string PropertyIsBookMark = "IsBookMark";

        #endregion

        #endregion

        #region General Initializer : Class (QueryInfo) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryInfo" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryInfo_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryInfo) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="QueryInfo" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryInfo_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryInfo) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryInfo" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryInfo_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryInfo)

        #region General Initializer : Class (QueryInfo) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryInfo" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyQueryId)]
        [TestCase(PropertyQueryName)]
        [TestCase(PropertyQueryMode)]
        [TestCase(PropertyQueryParameter)]
        [TestCase(PropertyProtectionMode)]
        [TestCase(PropertyParentFolderId)]
        [TestCase(PropertyNavigatorType)]
        [TestCase(PropertyNavigatorEntity)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyIsBookMark)]
        [Category("AUT Property")]
        public void AUT_QueryInfo_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (QueryInfo) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QueryInfo" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryInfo_Is_Instance_Present_Test()
        {
            // Assert
            _queryInfoInstanceType.ShouldNotBeNull();
            _queryInfoInstance.ShouldNotBeNull();
            _queryInfoInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (QueryInfo) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryInfo" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryInfo_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryInfoInstance.ShouldBeAssignableTo<QueryInfo>();
            _queryInfoInstanceFixture.ShouldBeAssignableTo<QueryInfo>();
            CurrentInstance.ShouldBeAssignableTo<QueryInfo>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (QueryInfo) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QueryInfo_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            QueryInfo instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (QueryInfo) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyQueryId)]
        [TestCase(PropertyQueryName)]
        [TestCase(PropertyQueryMode)]
        [TestCase(PropertyQueryParameter)]
        [TestCase(PropertyProtectionMode)]
        [TestCase(PropertyParentFolderId)]
        [TestCase(PropertyNavigatorType)]
        [TestCase(PropertyNavigatorEntity)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyIsBookMark)]
        public void AUT_QueryInfo_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (QueryInfo) => Property (IsBookMark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_IsBookMark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsBookMark);
            var propertyInfo = this.GetPropertyInfo(PropertyIsBookMark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (NavigatorEntity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_NavigatorEntity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorEntity);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorEntity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (NavigatorType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_NavigatorType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorType);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (OwnerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_OwnerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (ParentFolderId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_ParentFolderId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParentFolderId);
            var propertyInfo = this.GetPropertyInfo(PropertyParentFolderId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (ProtectionMode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_ProtectionMode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProtectionMode);
            var propertyInfo = this.GetPropertyInfo(PropertyProtectionMode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (QueryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_QueryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryId);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (QueryMode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_QueryMode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryMode);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryMode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (QueryName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_QueryName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryName);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryInfo) => Property (QueryParameter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryInfo_Public_Class_QueryParameter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryParameter);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryParameter);

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