using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Notification.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Notification.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.Model.TreeData" />)
    ///     and namespace <see cref="Onyx.UI.Notification.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TreeDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TreeData" />)
        /// </summary>
        public TreeDataTest() : base(typeof(TreeData))
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

        #region General Initializer : Class (TreeData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _treeDataInstanceType;
        private TreeData _treeDataInstance;
        private TreeData _treeDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TreeData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _treeDataInstanceType = typeof(TreeData);
            _treeDataInstanceFixture = this.Create<TreeData>(false);
            _treeDataInstance = _treeDataInstanceFixture ?? this.Create<TreeData>(true);
            CurrentInstance = _treeDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TreeData) Initializer

        #region Properties

        private const string Propertyid = "id";
        private const string Propertytext = "text";
        private const string Propertyleaf = "leaf";
        private const string PropertyCode = "Code";
        private const string PropertyparentId = "parentId";
        
        private const string Propertychildren = "children";

        #endregion

        #region Methods

        private const string MethodToString = "ToString";

        #endregion

        #region Fields

        private const string FieldparentItem = "parentItem";
        private const string Field_Id = "_Id";
        private const string Field_DisplayName = "_DisplayName";
        private const string Field_IsParent = "_IsParent";
        private const string Field_Code = "_Code";
        private const string Field_ParentId = "_ParentId";
        private const string FieldisChecked = "isChecked";
        private const string Field_children = "_children";

        #endregion

        #endregion

        #region General Initializer : Class (TreeData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TreeData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TreeData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TreeData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TreeData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TreeData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TreeData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TreeData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TreeData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TreeData)

        #region General Initializer : Class (TreeData) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TreeData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodToString, 0)]
        public void AUT_TreeData_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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
        
        #region General Initializer : Class (TreeData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TreeData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldparentItem)]
        [TestCase(Field_Id)]
        [TestCase(Field_DisplayName)]
        [TestCase(Field_IsParent)]
        [TestCase(Field_Code)]
        [TestCase(Field_ParentId)]
        [TestCase(FieldisChecked)]
        [TestCase(Field_children)]
        [Category("AUT Fields")]
        public void AUT_TreeData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TreeData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TreeData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TreeData_Is_Instance_Present_Test()
        {
            // Assert
            _treeDataInstanceType.ShouldNotBeNull();
            _treeDataInstance.ShouldNotBeNull();
            _treeDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TreeData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TreeData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TreeData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _treeDataInstance.ShouldBeAssignableTo<TreeData>();
            _treeDataInstanceFixture.ShouldBeAssignableTo<TreeData>();
            CurrentInstance.ShouldBeAssignableTo<TreeData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TreeData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TreeData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (TreeData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var Id = this.CreateType<string>();
            var displayName = this.CreateType<string>();
            var isParent = this.CreateType<bool>();
            TreeData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TreeData(Id, displayName, isParent);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _treeDataInstance.ShouldNotBeNull();
            _treeDataInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<TreeData>();
        }

        #endregion

        #region General Constructor : Class (TreeData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var Id = this.CreateType<string>();
            var displayName = this.CreateType<string>();
            var isParent = this.CreateType<bool>();
            TreeData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TreeData(Id, displayName, isParent);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _treeDataInstance.ShouldNotBeNull();
            _treeDataInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (TreeData) instance created

        /// <summary>
        ///     Class (<see cref="TreeData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Is_Created_Test()
        {
            // Assert
            _treeDataInstance.ShouldNotBeNull();
            _treeDataInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TreeData) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="TreeData" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void AUT_TreeData_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (TreeData) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="TreeData" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TreeData) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeData" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodTreeDataParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeDataParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeData) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeData" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeDataParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeData) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeData" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeDataParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeDataParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeData) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeData" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeDataParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeData) constructors with dynamic parameters (Overloading_Of_4_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeData" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructors_Overloading_Of_4_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(TreeData) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeDataParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeData) constructors with dynamic parameters (Overloading_Of_5_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeData" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeData_Constructors_Overloading_Of_5_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeDataParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(TreeData) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeDataParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter
        
        #region General Getters/Setters : Class (TreeData) => Property (children) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeData_Public_Class_children_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TreeData) => Property (Code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeData_Public_Class_Code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCode);
            var propertyInfo = this.GetPropertyInfo(PropertyCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeData) => Property (id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeData_Public_Class_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyid);
            var propertyInfo = this.GetPropertyInfo(Propertyid);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeData) => Property (leaf) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeData_Public_Class_leaf_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyleaf);
            var propertyInfo = this.GetPropertyInfo(Propertyleaf);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeData) => Property (parentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeData_Public_Class_parentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyparentId);
            var propertyInfo = this.GetPropertyInfo(PropertyparentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeData) => Property (text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeData_Public_Class_text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertytext);
            var propertyInfo = this.GetPropertyInfo(Propertytext);

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

        #region Method Call : (ToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TreeData_ToString_Method_Call_Internally(Type[] types)
        {
            var methodToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TreeData_ToString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);

            // Act
            Action executeAction = () => _treeDataInstance.ToString();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (ToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TreeData_ToString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_treeDataInstanceFixture, parametersOfToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TreeData_ToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TreeData_ToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion
        
        #endregion

        #endregion
    }
}