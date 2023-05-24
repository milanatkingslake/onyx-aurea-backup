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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.QueryTreeItem" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class QueryTreeItemTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryTreeItem" />)
        /// </summary>
        public QueryTreeItemTest() : base(typeof(QueryTreeItem))
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

        #region General Initializer : Class (QueryTreeItem) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryTreeItemInstanceType;
        private QueryTreeItem _queryTreeItemInstance;
        private QueryTreeItem _queryTreeItemInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QueryTreeItem" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryTreeItemInstanceType = typeof(QueryTreeItem);
            _queryTreeItemInstanceFixture = this.Create<QueryTreeItem>(false);
            _queryTreeItemInstance = _queryTreeItemInstanceFixture ?? this.Create<QueryTreeItem>(true);
            CurrentInstance = _queryTreeItemInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryTreeItem) Initializer

        #region Properties

        private const string Propertytext = "text";
        private const string PropertynodeId = "nodeId";
        private const string Propertytype = "type";
        private const string Propertyaction = "action";
        private const string Propertyloaded = "loaded";
        private const string Propertyleaf = "leaf";
        private const string Propertybookmark = "bookmark";
        private const string PropertyhomePageQuery = "homePageQuery";
        private const string Propertymobilebookmark = "mobilebookmark";
        private const string PropertymobilebookmarkEntity = "mobilebookmarkEntity";
        private const string PropertyqueryParameter = "queryParameter";
        private const string PropertynavigatorEntity = "navigatorEntity";
        private const string PropertyownerId = "ownerId";
        private const string PropertyparentNodeId = "parentNodeId";
        private const string Propertychildren = "children";

        #endregion

        #region Fields

        private const string Field_children = "_children";

        #endregion

        #endregion

        #region General Initializer : Class (QueryTreeItem) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryTreeItem" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryTreeItem_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryTreeItem) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="QueryTreeItem" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryTreeItem_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryTreeItem) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryTreeItem" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryTreeItem_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryTreeItem)

        #region General Initializer : Class (QueryTreeItem) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryTreeItem" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertytext)]
        [TestCase(PropertynodeId)]
        [TestCase(Propertytype)]
        [TestCase(Propertyaction)]
        [TestCase(Propertyloaded)]
        [TestCase(Propertyleaf)]
        [TestCase(Propertybookmark)]
        [TestCase(PropertyhomePageQuery)]
        [TestCase(Propertymobilebookmark)]
        [TestCase(PropertymobilebookmarkEntity)]
        [TestCase(PropertyqueryParameter)]
        [TestCase(PropertynavigatorEntity)]
        [TestCase(PropertyownerId)]
        [TestCase(PropertyparentNodeId)]
        [TestCase(Propertychildren)]
        [Category("AUT Property")]
        public void AUT_QueryTreeItem_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (QueryTreeItem) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryTreeItem" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_children)]
        [Category("AUT Fields")]
        public void AUT_QueryTreeItem_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (QueryTreeItem) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QueryTreeItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryTreeItem_Is_Instance_Present_Test()
        {
            // Assert
            _queryTreeItemInstanceType.ShouldNotBeNull();
            _queryTreeItemInstance.ShouldNotBeNull();
            _queryTreeItemInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (QueryTreeItem) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryTreeItem" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryTreeItem_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryTreeItemInstance.ShouldBeAssignableTo<QueryTreeItem>();
            _queryTreeItemInstanceFixture.ShouldBeAssignableTo<QueryTreeItem>();
            CurrentInstance.ShouldBeAssignableTo<QueryTreeItem>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (QueryTreeItem) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QueryTreeItem_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            QueryTreeItem instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (QueryTreeItem) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertytext)]
        [TestCase(PropertynodeId)]
        [TestCase(Propertytype)]
        [TestCase(Propertyaction)]
        [TestCase(Propertyloaded)]
        [TestCase(Propertyleaf)]
        [TestCase(Propertybookmark)]
        [TestCase(PropertyhomePageQuery)]
        [TestCase(Propertymobilebookmark)]
        [TestCase(PropertymobilebookmarkEntity)]
        [TestCase(PropertyqueryParameter)]
        [TestCase(PropertynavigatorEntity)]
        [TestCase(PropertyownerId)]
        [TestCase(PropertyparentNodeId)]
        [TestCase(Propertychildren)]
        public void AUT_QueryTreeItem_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (QueryTreeItem) => Property (action) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_action_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyaction);
            var propertyInfo = this.GetPropertyInfo(Propertyaction);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (bookmark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_bookmark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertybookmark);
            var propertyInfo = this.GetPropertyInfo(Propertybookmark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (children) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_children_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (QueryTreeItem) => Property (homePageQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_homePageQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyhomePageQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyhomePageQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (leaf) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_leaf_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (QueryTreeItem) => Property (loaded) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_loaded_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyloaded);
            var propertyInfo = this.GetPropertyInfo(Propertyloaded);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (mobilebookmark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_mobilebookmark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertymobilebookmark);
            var propertyInfo = this.GetPropertyInfo(Propertymobilebookmark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (mobilebookmarkEntity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_mobilebookmarkEntity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymobilebookmarkEntity);
            var propertyInfo = this.GetPropertyInfo(PropertymobilebookmarkEntity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (navigatorEntity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_navigatorEntity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynavigatorEntity);
            var propertyInfo = this.GetPropertyInfo(PropertynavigatorEntity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (nodeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_nodeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynodeId);
            var propertyInfo = this.GetPropertyInfo(PropertynodeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (ownerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_ownerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyownerId);
            var propertyInfo = this.GetPropertyInfo(PropertyownerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (parentNodeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_parentNodeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyparentNodeId);
            var propertyInfo = this.GetPropertyInfo(PropertyparentNodeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (queryParameter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_queryParameter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyqueryParameter);
            var propertyInfo = this.GetPropertyInfo(PropertyqueryParameter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (QueryTreeItem) => Property (text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (QueryTreeItem) => Property (type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_QueryTreeItem_Public_Class_type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertytype);
            var propertyInfo = this.GetPropertyInfo(Propertytype);

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