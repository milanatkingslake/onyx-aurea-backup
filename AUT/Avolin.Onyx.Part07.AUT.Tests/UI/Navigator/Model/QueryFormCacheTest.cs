using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.QueryFormCache" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class QueryFormCacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryFormCache" />)
        /// </summary>
        public QueryFormCacheTest() : base(typeof(QueryFormCache))
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

        #region General Initializer : Class (QueryFormCache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryFormCacheInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="QueryFormCache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryFormCacheInstanceType = typeof(QueryFormCache);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryFormCache) Initializer

        #region Properties

        private const string PropertyOldQueryName = "OldQueryName";

        #endregion

        #region Methods

        private const string MethodClearData = "ClearData";

        #endregion

        #region Fields

        private const string FieldQueryName = "QueryName";
        private const string FieldIsBookMark = "IsBookMark";
        private const string FieldSelectedFolderId = "SelectedFolderId";
        private const string FieldSelectedQueryId = "SelectedQueryId";
        private const string FieldSearchFormParameters = "SearchFormParameters";
        private const string FieldCurrentNavigatorEntitity = "CurrentNavigatorEntitity";
        private const string FieldIsHomePageQuery = "IsHomePageQuery";
        private const string FieldIsMobileBookMark = "IsMobileBookMark";

        #endregion

        #endregion

        #region General Initializer : Class (QueryFormCache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryFormCache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryFormCache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryFormCache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="QueryFormCache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryFormCache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryFormCache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryFormCache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryFormCache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryFormCache)

        #region General Initializer : Class (QueryFormCache) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="QueryFormCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodClearData, 0)]
        public void AUT_QueryFormCache_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (QueryFormCache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryFormCache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOldQueryName)]
        [Category("AUT Property")]
        public void AUT_QueryFormCache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (QueryFormCache) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryFormCache" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldQueryName)]
        [TestCase(FieldIsBookMark)]
        [TestCase(FieldSelectedFolderId)]
        [TestCase(FieldSelectedQueryId)]
        [TestCase(FieldSearchFormParameters)]
        [TestCase(FieldCurrentNavigatorEntitity)]
        [TestCase(FieldIsHomePageQuery)]
        [TestCase(FieldIsMobileBookMark)]
        [Category("AUT Fields")]
        public void AUT_QueryFormCache_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (QueryFormCache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QueryFormCache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryFormCache_Is_Static_Type_Present_Test()
        {
            // Assert
            _queryFormCacheInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ClearData) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryFormCache_ClearData_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearData);

            // Act
            Action executeAction = () => QueryFormCache.ClearData();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ClearData) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryFormCache_ClearData_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearData);
            Type [] methodClearDataParametersTypes = null;
            object[] parametersOfClearData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClearData, methodClearDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfClearData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClearData.ShouldBeNull();
            methodClearDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearData) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryFormCache_ClearData_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearData);
            Type [] methodClearDataParametersTypes = null;
            object[] parametersOfClearData = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClearData, parametersOfClearData, methodClearDataParametersTypes);

            // Assert
            parametersOfClearData.ShouldBeNull();
            methodClearDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearData) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryFormCache_ClearData_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearData);
            Type [] methodClearDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClearData, methodClearDataParametersTypes);

            // Assert
            methodClearDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ClearData) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryFormCache_ClearData_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClearData);
            var currentMethodInfo = this.GetMethodInfo(MethodClearData, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}