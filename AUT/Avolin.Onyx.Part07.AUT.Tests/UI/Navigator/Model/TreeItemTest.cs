using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.TreeItem" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TreeItemTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TreeItem" />)
        /// </summary>
        public TreeItemTest() : base(typeof(TreeItem))
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

        #region General Initializer : Class (TreeItem) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _treeItemInstanceType;
        private TreeItem _treeItemInstance;
        private TreeItem _treeItemInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TreeItem" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _treeItemInstanceType = typeof(TreeItem);
            _treeItemInstanceFixture = this.Create<TreeItem>(false);
            _treeItemInstance = _treeItemInstanceFixture ?? this.Create<TreeItem>(true);
            CurrentInstance = _treeItemInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TreeItem) Initializer

        #region Properties

        private const string PropertyId = "Id";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyIsParent = "IsParent";
        private const string PropertyCode = "Code";
        private const string PropertyParentDisplayName = "ParentDisplayName";
        private const string PropertyParentId = "ParentId";
        private const string PropertyIsExpanded = "IsExpanded";
        private const string PropertyItems = "Items";

        #endregion

        #region Fields

        private const string Field_items = "_items";

        #endregion

        #endregion

        #region General Initializer : Class (TreeItem) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TreeItem" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TreeItem_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TreeItem) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TreeItem" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TreeItem_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TreeItem) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TreeItem" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TreeItem_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TreeItem)

        #region General Initializer : Class (TreeItem) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TreeItem" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyId)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyIsParent)]
        [TestCase(PropertyCode)]
        [TestCase(PropertyParentDisplayName)]
        [TestCase(PropertyParentId)]
        [TestCase(PropertyIsExpanded)]
        [TestCase(PropertyItems)]
        [Category("AUT Property")]
        public void AUT_TreeItem_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TreeItem) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TreeItem" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_items)]
        [Category("AUT Fields")]
        public void AUT_TreeItem_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TreeItem) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TreeItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TreeItem_Is_Instance_Present_Test()
        {
            // Assert
            _treeItemInstanceType.ShouldNotBeNull();
            _treeItemInstance.ShouldNotBeNull();
            _treeItemInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TreeItem) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TreeItem" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TreeItem_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _treeItemInstance.ShouldBeAssignableTo<TreeItem>();
            _treeItemInstanceFixture.ShouldBeAssignableTo<TreeItem>();
            CurrentInstance.ShouldBeAssignableTo<TreeItem>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TreeItem) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var id = this.CreateType<string>();
            var displayName = this.CreateType<string>();
            TreeItem instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TreeItem(id, displayName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _treeItemInstance.ShouldNotBeNull();
            _treeItemInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<TreeItem>();
        }

        #endregion

        #region General Constructor : Class (TreeItem) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var id = this.CreateType<string>();
            var displayName = this.CreateType<string>();
            TreeItem instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TreeItem(id, displayName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _treeItemInstance.ShouldNotBeNull();
            _treeItemInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (TreeItem) instance created

        /// <summary>
        ///     Class (<see cref="TreeItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_Is_Created_Test()
        {
            // Assert
            _treeItemInstance.ShouldNotBeNull();
            _treeItemInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TreeItem) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="TreeItem" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void AUT_TreeItem_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (TreeItem) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="TreeItem" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TreeItem) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeItem" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeItemParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeItemParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeItem) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeItem" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeItemParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeItem) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeItem" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeItemParametersTypes);
        }

        #endregion

        #region General Constructor : Class (TreeItem) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TreeItem" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TreeItem_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTreeItemParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTreeItemParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TreeItem) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyId)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyIsParent)]
        [TestCase(PropertyCode)]
        [TestCase(PropertyParentDisplayName)]
        [TestCase(PropertyParentId)]
        [TestCase(PropertyIsExpanded)]
        [TestCase(PropertyItems)]
        public void AUT_TreeItem_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TreeItem) => Property (Code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_Code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TreeItem) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeItem) => Property (Id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_Id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyId);
            var propertyInfo = this.GetPropertyInfo(PropertyId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeItem) => Property (IsExpanded) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_IsExpanded_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsExpanded);
            var propertyInfo = this.GetPropertyInfo(PropertyIsExpanded);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeItem) => Property (IsParent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_IsParent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsParent);
            var propertyInfo = this.GetPropertyInfo(PropertyIsParent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeItem) => Property (Items) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_Items_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItems);
            var propertyInfo = this.GetPropertyInfo(PropertyItems);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeItem) => Property (ParentDisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_ParentDisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParentDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyParentDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TreeItem) => Property (ParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TreeItem_Public_Class_ParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParentId);
            var propertyInfo = this.GetPropertyInfo(PropertyParentId);

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