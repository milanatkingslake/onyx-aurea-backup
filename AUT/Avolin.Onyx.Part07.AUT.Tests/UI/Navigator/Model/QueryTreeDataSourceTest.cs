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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.QueryTreeDataSource" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class QueryTreeDataSourceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryTreeDataSource" />)
        /// </summary>
        public QueryTreeDataSourceTest() : base(typeof(QueryTreeDataSource))
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

        #region General Initializer : Class (QueryTreeDataSource) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryTreeDataSourceInstanceType;
        private QueryTreeDataSource _queryTreeDataSourceInstance;
        private QueryTreeDataSource _queryTreeDataSourceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QueryTreeDataSource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryTreeDataSourceInstanceType = typeof(QueryTreeDataSource);
            _queryTreeDataSourceInstanceFixture = this.Create<QueryTreeDataSource>(false);
            _queryTreeDataSourceInstance = _queryTreeDataSourceInstanceFixture ?? this.Create<QueryTreeDataSource>(true);
            CurrentInstance = _queryTreeDataSourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryTreeDataSource) Initializer

        #region Properties

        private const string Propertychildren = "children";

        #endregion

        #region Methods

        private const string MethodFindChildren = "FindChildren";

        #endregion

        #region Fields

        private const string Fieldtreequery = "treequery";
        private const string FieldtreeFolders = "treeFolders";

        #endregion

        #endregion

        #region General Initializer : Class (QueryTreeDataSource) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryTreeDataSource" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryTreeDataSource_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryTreeDataSource) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="QueryTreeDataSource" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryTreeDataSource_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryTreeDataSource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryTreeDataSource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryTreeDataSource_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryTreeDataSource)

        #region General Initializer : Class (QueryTreeDataSource) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="QueryTreeDataSource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodFindChildren, 0)]
        public void AUT_QueryTreeDataSource_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (QueryTreeDataSource) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryTreeDataSource" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertychildren)]
        [Category("AUT Property")]
        public void AUT_QueryTreeDataSource_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (QueryTreeDataSource) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryTreeDataSource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldtreequery)]
        [TestCase(FieldtreeFolders)]
        [Category("AUT Fields")]
        public void AUT_QueryTreeDataSource_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (QueryTreeDataSource) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryTreeDataSource" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryTreeDataSource_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryTreeDataSourceInstance.ShouldBeAssignableTo<QueryTreeDataSource>();
            _queryTreeDataSourceInstanceFixture.ShouldBeAssignableTo<QueryTreeDataSource>();
            CurrentInstance.ShouldBeAssignableTo<QueryTreeDataSource>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (QueryTreeDataSource) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertychildren)]
        public void AUT_QueryTreeDataSource_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (QueryTreeDataSource) => Property (children) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeDataSource_Public_Class_children_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertychildren);
            var propertyInfo = this.GetPropertyInfo(Propertychildren);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (FindChildren) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryTreeDataSource_FindChildren_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var item = this.CreateType<QueryTreeItem>();
            var methodFindChildrenParametersTypes = new Type[] { typeof(QueryTreeItem) };
            object[] parametersOfFindChildren = { item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFindChildren, methodFindChildrenParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryTreeDataSourceInstanceFixture, parametersOfFindChildren);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFindChildren.ShouldNotBeNull();
            parametersOfFindChildren.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(parametersOfFindChildren.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryTreeDataSource_FindChildren_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var item = this.CreateType<QueryTreeItem>();
            var methodFindChildrenParametersTypes = new Type[] { typeof(QueryTreeItem) };
            object[] parametersOfFindChildren = { item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFindChildren, parametersOfFindChildren, methodFindChildrenParametersTypes);

            // Assert
            parametersOfFindChildren.ShouldNotBeNull();
            parametersOfFindChildren.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(1);
            methodFindChildrenParametersTypes.Length.ShouldBe(parametersOfFindChildren.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryTreeDataSource_FindChildren_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodFindChildren, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryTreeDataSource_FindChildren_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var methodFindChildrenParametersTypes = new Type[] { typeof(QueryTreeItem) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindChildren, methodFindChildrenParametersTypes);

            // Assert
            methodFindChildrenParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindChildren) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryTreeDataSource_FindChildren_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodFindChildren, 0);

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