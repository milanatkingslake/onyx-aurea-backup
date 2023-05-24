using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ResultAdminDataSource" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResultAdminDataSourceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResultAdminDataSource" />)
        /// </summary>
        public ResultAdminDataSourceTest() : base(typeof(ResultAdminDataSource))
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

        #region General Initializer : Class (ResultAdminDataSource) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _resultAdminDataSourceInstanceType;
        private ResultAdminDataSource _resultAdminDataSourceInstance;
        private ResultAdminDataSource _resultAdminDataSourceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResultAdminDataSource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resultAdminDataSourceInstanceType = typeof(ResultAdminDataSource);
            _resultAdminDataSourceInstanceFixture = this.Create<ResultAdminDataSource>(false);
            _resultAdminDataSourceInstance = _resultAdminDataSourceInstanceFixture ?? this.Create<ResultAdminDataSource>(true);
            CurrentInstance = _resultAdminDataSourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResultAdminDataSource) Initializer

        #region Properties

        private const string PropertyTreeSource = "TreeSource";

        #endregion

        #region Methods

        private const string MethodFindChildren = "FindChildren";

        #endregion

        #region Fields

        private const string FieldtreeFolders = "treeFolders";
        private const string FieldtreeData = "treeData";

        #endregion

        #endregion

        #region General Initializer : Class (ResultAdminDataSource) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultAdminDataSource_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultAdminDataSource) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultAdminDataSource_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultAdminDataSource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultAdminDataSource_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResultAdminDataSource)

        #region General Initializer : Class (ResultAdminDataSource) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodFindChildren, 0)]
        public void AUT_ResultAdminDataSource_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ResultAdminDataSource) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTreeSource)]
        [Category("AUT Property")]
        public void AUT_ResultAdminDataSource_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ResultAdminDataSource) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldtreeFolders)]
        [TestCase(FieldtreeData)]
        [Category("AUT Fields")]
        public void AUT_ResultAdminDataSource_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ResultAdminDataSource) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultAdminDataSource_Is_Instance_Present_Test()
        {
            // Assert
            _resultAdminDataSourceInstanceType.ShouldNotBeNull();
            _resultAdminDataSourceInstance.ShouldNotBeNull();
            _resultAdminDataSourceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResultAdminDataSource) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultAdminDataSource_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _resultAdminDataSourceInstance.ShouldBeAssignableTo<ResultAdminDataSource>();
            _resultAdminDataSourceInstanceFixture.ShouldBeAssignableTo<ResultAdminDataSource>();
            CurrentInstance.ShouldBeAssignableTo<ResultAdminDataSource>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResultAdminDataSource) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultAdminDataSource_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResultAdminDataSource instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ResultAdminDataSource) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultAdminDataSource_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var Source = this.CreateType<ResultFilterConfiguration>();
            ResultAdminDataSource instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ResultAdminDataSource(Source);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _resultAdminDataSourceInstance.ShouldNotBeNull();
            _resultAdminDataSourceInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ResultAdminDataSource>();
        }

        #endregion

        #region General Constructor : Class (ResultAdminDataSource) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultAdminDataSource_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var Source = this.CreateType<ResultFilterConfiguration>();
            ResultAdminDataSource instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ResultAdminDataSource(Source);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _resultAdminDataSourceInstance.ShouldNotBeNull();
            _resultAdminDataSourceInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ResultAdminDataSource) instance created

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultAdminDataSource_Is_Created_Test()
        {
            // Assert
            _resultAdminDataSourceInstance.ShouldNotBeNull();
            _resultAdminDataSourceInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ResultAdminDataSource) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ResultAdminDataSource" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_ResultAdminDataSource_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (ResultAdminDataSource) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ResultAdminDataSource" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultAdminDataSource_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ResultAdminDataSource) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ResultAdminDataSource" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultAdminDataSource_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodResultAdminDataSourceParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodResultAdminDataSourceParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ResultAdminDataSource) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ResultAdminDataSource" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultAdminDataSource_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodResultAdminDataSourceParametersTypes = new Type[] { typeof(ResultFilterConfiguration) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodResultAdminDataSourceParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ResultAdminDataSource) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTreeSource)]
        public void AUT_ResultAdminDataSource_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ResultAdminDataSource) => Property (TreeSource) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultAdminDataSource_TreeSource_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTreeSource);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyTreeSource);
            Action currentAction = () => propertyInfo.SetValue(_resultAdminDataSourceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ResultAdminDataSource) => Property (TreeSource) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultAdminDataSource_Public_Class_TreeSource_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTreeSource);
            var propertyInfo = this.GetPropertyInfo(PropertyTreeSource);

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
        public void AUT_ResultAdminDataSource_FindChildren_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var item = this.CreateType<ResultFilterProfile>();
            var methodFindChildrenParametersTypes = new Type[] { typeof(ResultFilterProfile) };
            object[] parametersOfFindChildren = { item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFindChildren, methodFindChildrenParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_resultAdminDataSourceInstanceFixture, parametersOfFindChildren);

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
        public void AUT_ResultAdminDataSource_FindChildren_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var item = this.CreateType<ResultFilterProfile>();
            var methodFindChildrenParametersTypes = new Type[] { typeof(ResultFilterProfile) };
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
        public void AUT_ResultAdminDataSource_FindChildren_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_ResultAdminDataSource_FindChildren_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindChildren);
            var methodFindChildrenParametersTypes = new Type[] { typeof(ResultFilterProfile) };

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
        public void AUT_ResultAdminDataSource_FindChildren_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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